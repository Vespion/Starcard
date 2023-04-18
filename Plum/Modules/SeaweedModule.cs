using System.Collections.Generic;
using System.Text;
using Pulumi;
using Pulumi.Kubernetes.Batch.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Batch.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

namespace Plum.Modules;

public class SeaweedModule: ComponentModule
{
	/// <inheritdoc />
	public SeaweedModule(ComponentResourceOptions? options = null) : base("seaweed", options)
	{
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		DeployChart(config);
		ProvisionerJob();
	}

	private void ProvisionerJob()
	{
		var configBuilder = new StringBuilder()
			.AppendLine("[default]")
			.AppendLine("use_https = No")
			.AppendLine("guess_mime_type = True")
			.AppendLine("signature_v2 = False")
			.AppendLine("access_key = any_no_empty_key")
			.AppendLine("secret_key = any_no_empty_key")
			.AppendLine($"host_base = seaweedfs-s3.{StorageNamespace}.svc.cluster.local:8333")
			.AppendLine($"host_bucket = seaweedfs-s3.{StorageNamespace}.svc.cluster.local:8333");

		var configMap = new ConfigMap("s3-config", new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = StorageNamespace
			},
			Data = new InputMap<string>
			{
				{ ".s3cfg", configBuilder.ToString() }
			} 
		}, new CustomResourceOptions
		{
			Parent = this
		});


		Job ProvisionBucket(string name, string ns = StorageNamespace)
		{
			return new Job($"provision-bucket-{name}", new JobArgs
			{
				Metadata = new ObjectMetaArgs
				{
					Name = $"provision-bucket-{name}",
					Namespace = ns
				},
				Spec = new JobSpecArgs
				{
					BackoffLimit = 12,
					// Job can't be deleted as it would break pulumi's state
					// TtlSecondsAfterFinished = 120, 
					Template = new PodTemplateSpecArgs
					{
						Spec = new PodSpecArgs
						{
							RestartPolicy = "OnFailure",
							Containers = new ContainerArgs[]
							{
								new()
								{
									Image = "d3fk/s3cmd:arch-stable",
									Name = $"provision-bucket-{name}",
									Args = new InputList<string>
									{
										"--debug",
										"mb",
										$"s3://{name}"
									},
									VolumeMounts = new VolumeMountArgs[]
									{
										new()
										{
											MountPath = "/root/.s3cfg",
											SubPath = ".s3cfg",
											Name = "config",
											ReadOnly = true
										}
									}
								}
							},
							Volumes = new VolumeArgs[]
							{
								new()
								{
									Name = "config",
									ConfigMap = new ConfigMapVolumeSourceArgs
									{
										Name = configMap.Metadata.Apply(x => x.Name)
									}
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

		ProvisionBucket("thanos");
		// ProvisionBucket("loki-chunks"); //Provisioned by loki
		ProvisionBucket("loki-ruler");
		ProvisionBucket("loki-admin");
		ProvisionBucket("loki-index");
		ProvisionBucket("db-backups");
	}
	
	private void DeployChart(Config config, string name = "seaweed", bool monitoring = true, bool reuseValues = false, params Resource[] deps)
	{
		var expose = config.GetBoolean("Traefik/OpenSeaweedPorts") ?? false;
		
		var val = new Dictionary<string, object>
		{
			["global"] = new Dictionary<string, object>
			{
				["enableReplication"] = false,
				["enableSecurity"] = false,
				["monitoring"] = new Dictionary<string, object>
				{
					["enabled"] = monitoring
				}
			},
			["master"] = new Dictionary<string, object>
			{
				["replicas"] = 3,
				["defaultReplicaPlacement"] = "001",
				["data"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "1500Mi"
				},
				["logs"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "1500Mi"
				},
				["priorityClassName"] = "system-cluster-critical",
				["ingress"] = new Dictionary<string, object>
				{
					["enabled"] = expose,
					["className"] = null!,
					["annotations"] = new Dictionary<string, string>
					{
						["traefik.ingress.kubernetes.io/router.entrypoints"] = "websecure"
					}
				}
			},
			["volume"] = new Dictionary<string, Input<object?>>
			{
				["replicas"] = 3,
				["defaultReplicaPlacement"] = "011",
				["dataCenter"] = config.Get("ClusterType"),
				["rack"] = "$(cat /var/run/node)",
				["initContainers"] =
@"- name: init-node-name
  image: busybox
  command: ['/bin/sh', '-c']
  args: ['echo $NODE_NAME > /var/run/node']
  env:
    - name: NODE_NAME
      valueFrom:
        fieldRef:
          fieldPath: spec.nodeName
  volumeMounts:
  - name: node
    mountPath: /var/run",
				["extraVolumeMounts"] = 
@"- name: node
  mountPath: /var/run
  readOnly: true",
				["extraVolumes"] = 
@"- name: node
  emptyDir: {}",
				["data"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "2Gi"
				},
				["idx"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "1Gi"
				},
				["logs"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "1500Mi"
				},
				["priorityClassName"] = "system-cluster-critical"
			},
			["filer"] = new Dictionary<string, object>
			{
				["replicas"] = 1,
				["defaultReplicaPlacement"] = "011",
				["data"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "2Gi"
				},
				["logs"] = new Dictionary<string, object>
				{
					["type"] = "persistentVolumeClaim",
					["size"] = "1500Mi"
				},
				["priorityClassName"] = "system-cluster-critical",
				["ingress"] = new Dictionary<string, object>
				{
					["enabled"] = expose,
					["className"] = null!,
					["annotations"] = new Dictionary<string, string>
					{
						["traefik.ingress.kubernetes.io/router.entrypoints"] = "websecure"
					}
				}
			}
		};

		var release = CreateHelmRelease(
			name,
			"seaweedfs",
			"https://seaweedfs.github.io/seaweedfs/helm",
			StorageNamespace,
			releaseName: "seaweed",
			val: val,
			reuseValues: reuseValues,
			deps: deps);
	}
}