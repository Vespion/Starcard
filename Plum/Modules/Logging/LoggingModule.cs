using Pulumi;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Crds.Fluentbit.V1Alpha2;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2;

namespace Plum.Modules;

public class LoggingModule: ComponentModule
{
	/// <inheritdoc />
	public LoggingModule(ComponentResourceOptions? options = null) : base("logging", options)
	{
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var fluentdOperator = DeployFluentdOperator();
		var loki = DeployLoki(config);

		if (config.GetBoolean("Monitoring/ProcessAuditDLogs") ?? false)
		{
			DeployAuditPipe();
		}

		ExcludeLokiLogs(loki);
		DeployLokiOutput(loki);
	}

	private void ExcludeLokiLogs(Release loki)
	{
		_ = new ClusterFilter("loki-exclusion", new ClusterFilterArgs
		{
			Spec = new ClusterFilterSpecArgs
			{
				Match = "kube.*",
				Filters = new ClusterFilterSpecFiltersArgs[]
				{
					new()
					{
						Grep = new ClusterFilterSpecFiltersGrepArgs
						{
							Exclude = "$.kubernetes.pod_name loki.*$"
						}
					}
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this,
			DependsOn =
			{
				loki
			}
		});
	}
	
	private void DeployAuditPipe()
	{
		_ = new ClusterInput("auditd-in", new ClusterInputArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = MonitoringNamespace,
				Labels = new InputMap<string>
				{
					["fluentbit.fluent.io/enabled"] = "true"
				}
			},
			Spec = new ClusterInputSpecArgs
			{
				Tail = new ClusterInputSpecTailArgs
				{
					Tag = "auditd",
					Path = "/var/log/audit/audit.log",
					RefreshIntervalSeconds = 10,
					MemBufLimit = "5MB",
					Db = "/tail/auditd.db",
					DbSync = "Normal"
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});

		var luaConfigMap = new ConfigMap("auditd-lua-filter-config", new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = MonitoringNamespace
			},
			Data = new InputMap<string>
			{
				["auditd.lua"] = System.IO.File.ReadAllText("./Modules/Logging/auditd.lua")
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
		
		_ = new ClusterFilter("auditd-filter", new ClusterFilterArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = MonitoringNamespace,
				Labels = new InputMap<string>
				{
					["fluentbit.fluent.io/enabled"] = "true"
				}
			},
			Spec = new ClusterFilterSpecArgs
			{
				Match = "auditd",
				Filters = new ClusterFilterSpecFiltersArgs[]
				{
					new()
					{
						RecordModifier = new ClusterFilterSpecFiltersRecordmodifierArgs
						{
							Records = new []
							{
								"node_name ${NODE_NAME}"
							}
						}
					},
					new()
					{
						Lua = new ClusterFilterSpecFiltersLuaArgs
						{
							Script = new ClusterFilterSpecFiltersLuaScriptArgs
							{
								Key = "auditd.lua",
								Name = luaConfigMap.Metadata.Apply(x => x.Name)
							},
							Call = "cb_replace",
							TimeAsTable = true
						}
					}
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}
	
	private ClusterOutput DeployLokiOutput(Release loki)
	{
		return new ClusterOutput("loki-output", new ClusterOutputArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = MonitoringNamespace,
				Labels = new InputMap<string>
				{
					["fluentbit.fluent.io/enabled"] = "true"
				}
			},
			Spec = new ClusterOutputSpecArgs
			{
				Match = "*",
				Loki = new ClusterOutputSpecLokiArgs
				{
					Host = "loki-gateway.monitoring.svc.cluster.local",
					Port = 80
				}
			}
		}, new CustomResourceOptions
		{
			DependsOn =
			{
				loki
			},
			Parent = this
		});
	}

	private Release DeployLoki(Config config)
	{
		var values = new InputMap<object>
		{
			["minio"] = new InputMap<object>
			{
				["enabled"] = false
			},
			["read"] = new InputMap<object>
			{
				["autoscaling"] = new InputMap<object>
				{
					["enabled"] = true
				}
			},
			["write"] = new InputMap<object>
			{
				["autoscaling"] = new InputMap<object>
				{
					["enabled"] = true
				}
			},
			["loki"] = new InputMap<object>
			{
				["auth_enabled"] = false, //Auth handled by grafana
				["storage"] = new InputMap<object>
				{
					["type"] = "s3",
					["bucketNames"] = new InputMap<string>
					{
						["chunks"] = "loki-chunks",
						["ruler"] = "loki-ruler",
						["admin"] = "loki-admin",
						["index"] = "loki-index"
					},
					["s3"] = new InputMap<object>
					{
						["s3"] = $"s3://seaweedfs-s3.{StorageNamespace}.svc.cluster.local:8333",
						["endpoint"] = "",
						["s3ForcePathStyle"] = true,
						["secretAccessKey"] = "any_no_empty_key",
						["accessKeyId"] = "any_no_empty_key",
						["insecure"] = true
					}
				}
			}
		};
		
		return CreateHelmRelease(
			"loki",
			"loki",
			"https://grafana.github.io/helm-charts",
			MonitoringNamespace,
			skipAwait: true, //Loki takes a while to stabilize, deploy it and move on
			val: values);
	}
	
	private Release DeployFluentdOperator()
	{
		var values = new InputMap<object>
		{
			["containerRuntime"] = "containerd",
			["disableComponentControllers"] = "fluentd",
			["fluentbit"] = new InputMap<object>
			{
				// ["additionalVolumes"] = new InputMap<object>[]
				// {
				// 	new()
				// 	{
				// 		["name"] = "host-proc",
				// 		["hostPath"] = new InputMap<object>
				// 		{
				// 			["path"] = "/proc/"
				// 		}
				// 	},
				// 	new()
				// 	{
				// 		["name"] = "host-sys",
				// 		["hostPath"] = new InputMap<object>
				// 		{
				// 			["path"] = "/sys/"
				// 		}
				// 	}
				// },
				// ["additionalVolumeMounts"] = new InputMap<object>[]
				// {
				// 	new()
				// 	{
				// 		["name"] = "host-proc",
				// 		["mountPath"] = "/host/proc",
				// 		["readOnly"] = true,
				// 		["mountPropagation"] = "HostToContainer"
				// 	},
				// 	new()
				// 	{
				// 		["name"] = "host-sys",
				// 		["mountPath"] = "/host/sys",
				// 		["readOnly"] = true,
				// 		["mountPropagation"] = "HostToContainer"
				// 	}
				// },
				// ["input"] = new InputMap<object>
				// { 
				// 	["nodeExporterMetrics"] = new InputMap<object>
				// 	{
				// 		["tag"] = "node_metrics",
				// 		["scrapeInterval"] = "15s",
				// 		["path"] = new InputMap<object>
				// 		{
				// 			["procfs"] = "/host/proc",
				// 			["sysfs"] = "/host/sys"
				// 		}
				// 	}
				// },
				["output"] = new InputMap<object>
				{ 
					["stdout"] = new InputMap<object>
					{
						["enable"] = false
					}
				}
			},
			["fluentd"] = new InputMap<object>
			{
				["enabled"] = false,
				["crdsEnabled"] = false
			}
		};
		
		return CreateHelmRelease(
			"fluentd-operator",
			"https://github.com/fluent/helm-charts/releases/download/fluent-operator-2.1.0/fluent-operator-2.1.0.tgz",
			null,
			MonitoringNamespace,
			val: values);
	}
}