using System.Collections.Generic;
using Pulumi;
using Pulumi.Crds.Traefik.V1Alpha1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1;

namespace Plum;

public class NetworkModule: ComponentModule
{
	internal static Dictionary<string, object> BuildIngressConfig(Config config, string subdomain, string entrypoint = "web")
	{
		var fullDomain = $"{subdomain}.{config.Require("DomainSuffix")}";
		return new Dictionary<string, object>
		{
			["enabled"] = true,
			["hosts"] = new[] { fullDomain },
			["host"] = fullDomain,
			["annotations"] = new Dictionary<string, string>
			{
				["traefik.ingress.kubernetes.io/router.entrypoints"] = entrypoint
			}
		};
	}
	
	Release DeployChart(Input<string> prometheusLabel)
	{
		var values = new Dictionary<string, object>
		{
			["priorityClassName"] = "system-cluster-critical",
			["podDisruptionBudget"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["minAvailable"] = 1
			},
			["podSecurityPolicy"] = new Dictionary<string, object>
			{
				["enabled"] = false
			},
			["metrics"] = new Dictionary<string, object>
			{
				["prometheus"] = new Dictionary<string, object>
				{
					["service"] = new Dictionary<string, object>
					{
						["enabled"] = true
					},
					["prometheusRule"] = new Dictionary<string, object>
					{
						["rules"] = new Dictionary<string, object>[]
						{
							new()
							{
								["alert"] = "TraefikDown",
								["expr"] = "up{job=\"traefik\"} == 0",
								["for"] = "5m",
								["labels"] = new Dictionary<string, object>
								{
									["severity"] = "warning",
									["context"] = "traefik"
								},
								["annotations"] = new Dictionary<string, object>
								{
									["summary"] = "Traefik Down",
									["description"] = "{{ $labels.pod }} on {{ $labels.nodename }} is down"
								}
							}
						}
					},
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["additionalLabels"] = new InputMap<string>
							{
								{"release", prometheusLabel}
							},
						["jobLabel"] = "traefik",
						["interval"] = "30s",
						["honorLabels"] = true,
						["honorTimestamps"] = true,
						["scrapeTimeout"] = "5s",
						["enableHttp2"] = true,
						["metricRelabelings"] = new Dictionary<string, object>[]
						{
							new()
							{
								{"sourceLabels", new[] {"__name__"}},
								{"separator", ";"},
								{"regex", "^fluentd_output_status_buffer_(oldest|newest)_.+"},
								{"action", "drop"},
								{"replacement", "$1"}
							}
						},
						["relabelings"] = new Dictionary<string, object>[]
						{
							new()
							{
								{"sourceLabels", new[] {"__meta_kubernetes_pod_node_name"}},
								{"separator", ";"},
								{"regex", "^(.*)$"},
								{"action", "replace"},
								{"targetLabel", "nodename"},
								{"replacement", "$1"}
							}
						}
					}
				}
			},
			["autoscaling"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["minReplicas"] = 1,
				["maxReplicas"] = 3,
				["behavior"] = new Dictionary<string, object>
				{
					["scaleDown"] = new Dictionary<string, object>
					{
						["stabilizationWindowSeconds"] = 300,
						["policies"] = new Dictionary<string, object>[]
						{
							new()
							{
								{"type", "Pods"},
								{"value", 1},
								{"periodSeconds", 60}
							}
						}
					}
				},
				["metrics"] = new Dictionary<string, object>[]
				{
					new()
					{
						{"type", "Resource"},
						{"resource", new Dictionary<string, object>
							{
								{"name", "cpu"},
								{"target", new Dictionary<string, object>
									{
										{"type", "Utilization"},
										{"averageUtilization", 60}
									}
								}
							}
						}
					},
					new()
					{
						{"type", "Resource"},
						{"resource", new Dictionary<string, object>
							{
								{"name", "memory"},
								{"target", new Dictionary<string, object>
									{
										{"type", "Utilization"},
										{"averageUtilization", 60}
									}
								}
							}
						}
					}
				}
			}
		};
		
		return CreateHelmRelease("traefik", "traefik", "https://traefik.github.io/charts", NetworkNamespace,
			"22.1.0", val: values
			);
	}
	
	private void ExposeDashboard(Config config, Release chart)
	{
		var manifest = new IngressRoute("traefik-dashboard", new IngressRouteArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Name = "traefik-dash",
				Namespace = chart.Namespace
			},
			Spec = new IngressRouteSpecArgs
			{
				EntryPoints = new []
				{
					"web"
				},
				Routes = new []
				{
					new IngressRouteSpecRoutesArgs
					{
						Match = $"Host(`traefik.{config.Require("DomainSuffix")}`)",
						Kind = "Rule",
						Services = new []
						{
							new IngressRouteSpecRoutesServicesArgs
							{
								Name = "api@internal",
								Kind = "TraefikService"
							}
						}
					}
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}

	private void InstallGrafanaDashboard(Release chart)
	{
		_ = new ConfigMap("traefik-dash-config", new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = chart.Namespace,
				Labels = new InputMap<string>
				{
					{ "app.kubernetes.io/name", "traefik" },
					{ "grafana_dashboard", "1" }
				}
			},
			Data = new InputMap<string>
			{
				{ "traefik.json", System.IO.File.ReadAllText("./Dashboards/traefik-official-kubernetes-dashboard_rev7.json") }
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}
	
	/// <inheritdoc />
	public NetworkModule(ComponentResourceOptions options) : base("network", options)
	{
		
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var chart = DeployChart("kube-prometheus");
		
		if (config.GetBoolean("Traefik/EnableDashboard") ?? false)
		{
			ExposeDashboard(config, chart);
		}
		
		InstallGrafanaDashboard(chart);
	}
}