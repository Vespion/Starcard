using System.Collections.Generic;
using System.Text;
using Pulumi;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

namespace Plum.Modules;

public class MonitoringModule: ComponentModule
{
	/// <inheritdoc />
	public MonitoringModule(ComponentResourceOptions? options = null) : base("monitoring", options)
	{
	}
	
	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		_isThanosDeployment = config.GetBoolean("Prometheus/UseThanos") ?? false;
		_openPorts = config.GetBoolean("Traefik/OpenPrometheusPorts") ?? false;
		
		var prometheus = InstallChart(config);
		if (_isThanosDeployment)
		{
			DeployThanos(config, prometheus);
		}
	}
	
	private void DeployThanos(Config config, Release prometheusRelease)
	{
		var storageConfig = DeployThanosStorage(prometheusRelease);
		
		DeployThanosChart(config, prometheusRelease, storageConfig);
		
		_ = new ConfigMap("thanos-dash-config", new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = prometheusRelease.Namespace,
				Labels = new InputMap<string>
				{
					{ "app.kubernetes.io/name", "thanos" },
					{ "grafana_dashboard", "1" }
				}
			},
			Data = new InputMap<string>
			{
				{ "thanos.json", System.IO.File.ReadAllText("./Dashboards/thanos-overview-public_rev4.json") }
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}

	private bool _isThanosDeployment;
	private bool _openPorts;
	
	private Output<string> DeployThanosStorage(Release prometheusRelease)
	{
		var configBuilder = new StringBuilder()
			.AppendLine("type: s3")
			.AppendLine("config:")
			.AppendLine("  bucket: thanos")
			.AppendLine($"  endpoint: seaweedfs-s3.{StorageNamespace}.svc.cluster.local:8333")
			.AppendLine("  insecure: true");
		
		return new Secret("thanos-storage-config", new SecretArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = prometheusRelease.Namespace,
				Name = "thanos-object-storage"
			},
			StringData = new InputMap<string>
			{
				{ "object-store.yaml", configBuilder.ToString() }
			}
		}, new CustomResourceOptions
		{
			Parent = this
		}).Metadata.Apply(x => x.Name);
	}
	
	private void DeployThanosChart(Config config, Release prometheusRelease, Input<string> storageConfig)
	{

		var values = new Dictionary<string, object>
		{
			["objstoreSecretOverride"] = "thanos-object-storage",
			["store"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				}
			},
			["compact"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				}
			},
			["bucket"] = new Dictionary<string, object>
			{
				["enabled"] = false,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				}
			},
			["rule"] = new Dictionary<string, object>
			{
				["enabled"] = false,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				}
			},
			["sidecar"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				},
				["selector"] = new Dictionary<string, string>
				{
					["app.kubernetes.io/name"] = "prometheus"
				}
			},
			["queryFrontend"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				},
				["autoscaling"] = new Dictionary<string, object>
				{
					["enabled"] = false,
					["minReplicas"] = 1,
					["maxReplicas"] = 3,
					["targetCPUUtilizationPercentage"] = 80
				},
				["podDisruptionBudget"] = new Dictionary<string, object>
				{
					["enabled"] = false,
					["minAvailable"] = 1
				}
			},
			["query"] = new Dictionary<string, object>
			{
				["enabled"] = true,
				["replicaLabels"] = new []
				{
					"replica"
				},
				["stores"] = new []
				{
					Output.Format($"dnssrv+_grpc._tcp.{prometheusRelease.Name}-kube-prome-thanos-discovery.{prometheusRelease.Namespace}.svc.cluster.local")
				},
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true,
					}
				},
				["autoscaling"] = new Dictionary<string, object>
				{
					["enabled"] = false,
					["minReplicas"] = 1,
					["maxReplicas"] = 3,
					["targetCPUUtilizationPercentage"] = 80
				},
				["podDisruptionBudget"] = new Dictionary<string, object>
				{
					["enabled"] = false,
					["minAvailable"] = 1
				}
			}
		};
		
		if (_openPorts)
		{
			var query = (Dictionary<string, object>)values["queryFrontend"];

			if (!query.ContainsKey("http"))
			{
				query.Add("http", new Dictionary<string, object>());
			}
			
			var http = (Dictionary<string, object>)query["http"];
			
			var ingress = NetworkModule.BuildIngressConfig(config, "metrics");
			ingress["apiVersion"] = "networking.k8s.io/v1";

			http["ingress"] = ingress;
		}
		
		CreateHelmRelease(
			"thanos",
			"thanos",
			"https://kubernetes-charts.banzaicloud.com",
			prometheusRelease.Namespace,
			val: values
		);
	}
	
	private Release InstallChart(Config config)
	{
		var values = new Dictionary<string, object>
		{
			["global"] = new Dictionary<string, object>
			{
				["rbac"] = new Dictionary<string, object>
				{
					["createAggregateClusterRoles"] = true,
					["pspEnabled"] = false
				}
			},
			["grafana"] = new Dictionary<string, object>
			{
				["ingress"] = NetworkModule.BuildIngressConfig(config, "grafana"),
				["sidecar"] = new Dictionary<string, object>
					{
						["enableUniqueFilenames"] = true,
						["alerts"] = new Dictionary<string, object>
						{
							["enabled"] = false,
							["searchNamespace"] = "ALL"
						},
						["notifiers"] = new Dictionary<string, object>
						{
							["enabled"] = false,
							["searchNamespace"] = "ALL"
						},
						["dashboards"] = new Dictionary<string, object>
						{
							["enabled"] = true,
							["searchNamespace"] = "ALL"
						}
					},
				["imageRenderer"] = new Dictionary<string, object>
				{
					["enabled"] = true
				}
			},
			["alertmanager"] = new Dictionary<string, object>
			{
				["podDisruptionBudget"] = new Dictionary<string, object>
				{
					["enabled"] = true
				}
			},
			["prometheus"] = new Dictionary<string, object>
			{
				["podDisruptionBudget"] = new Dictionary<string, object>
				{
					["enabled"] = true
				},
				["serviceAccount"] = new Dictionary<string, object>
					{
						["name"] = "prometheus"
					},
				["prometheusSpec"] = new Dictionary<string, object>
				{
					["resources"] = new Dictionary<string, object>
					{
						["requests"] = new Dictionary<string, object>
						{
							["cpu"] = "512m",
							["memory"] = "3072Mi"
						},
						["limits"] = new Dictionary<string, object>
						{
							["cpu"] = "512m",
							["memory"] = "4096Mi"
						},
					},
					["replicaExternalLabelName"] = "replica",
					["prometheusExternalLabelName"] = "cluster",
					["serviceMonitorSelectorNilUsesHelmValues"] = false,
					["retention"] = "6h"
				},
				["thanosService"] = new Dictionary<string, object>
				{
					["enabled"] = _isThanosDeployment
				},
				["thanosServiceMonitor"] = new Dictionary<string, object>
				{
					["enabled"] = _isThanosDeployment
				}
			},
			["prometheusOperator"] = new Dictionary<string, object>
			{
				["verticalPodAutoscaler"] = new Dictionary<string, object>
				{
					["enabled"] = true,
					["maxAllowed"] = new Dictionary<string, string>
					{
						["cpu"] = "0.5",
						["memory"] = "0.5Gi"
					}
				}
			}
		};

		T Extract<T>(IDictionary<string, object> dict, string key) where T: new()
		{
			if (!dict.ContainsKey(key))
			{
				dict.Add(key, new T());
			}
			
			return (T) dict[key];
		}
		
		if (_openPorts && !_isThanosDeployment)
		{
			var prom = (Dictionary<string, object>)values["prometheus"];
			var ingress = NetworkModule.BuildIngressConfig(config, "metrics");
			prom["ingress"] = ingress;
		}

		if (_isThanosDeployment)
		{
			Log.Info("Configuring Thanos deployment");

			var prometheus = Extract<Dictionary<string, object>>(values, "prometheus");
			var prometheusSpec = Extract<Dictionary<string, object>>(prometheus, "prometheusSpec");
			prometheusSpec["replicas"] = config.GetInt32("Prometheus/Replicas") ?? 1;
			prometheusSpec["shards"] = config.GetInt32("Prometheus/Shards") ?? 1;

			prometheusSpec["thanos"] = new Dictionary<string, object>
			{
				["objectStorageConfig"] = new Dictionary<string, object>
				{
					["key"] = "object-store.yaml",
					["name"] = "thanos-object-storage"
				}
			};
			
			var grafana = Extract<Dictionary<string, object>>(values, "grafana");
			var grafanaSidecar = Extract<Dictionary<string, object>>(grafana, "sidecar");
			var datasourcesSidecar = Extract<Dictionary<string, object>>(grafanaSidecar, "datasources");
			datasourcesSidecar["defaultDatasourceEnabled"] = false;

			var additionalDataSources = Extract<List<Dictionary<string, object>>>(grafana, "additionalDataSources");
			additionalDataSources.Add(new Dictionary<string, object>
			{
				["name"] = "Thanos",
				["ui"] = "prometheus-thanos",
				["type"] = "prometheus",
				["url"] = $"http://thanos-query-frontend-http.{MonitoringNamespace}.svc.cluster.local:10902",
				["access"] = "proxy",
				["isDefault"] = true,
				["jsonData"] = new Dictionary<string, object>
				{
					["timeInterval"] = "30s"
				}
			});
		}

		var release = CreateHelmRelease(
			"kube-prometheus",
			"kube-prometheus-stack",
			"https://prometheus-community.github.io/helm-charts",
			MonitoringNamespace,
			"45.9.1",
			val: values
			//,skipAwait: true //The release depends on resources further down the pipe so skip waiting for a ready status
		);

		return release;
	}
}