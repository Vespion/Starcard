using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Pulumi;
using Pulumi.Kubernetes.Batch.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Rbac.V1;
using Pulumi.Kubernetes.Types.Inputs.Batch.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Rbac.V1;
using Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1;

namespace Plum.Modules;

public class VaultModule: ComponentModule
{
	private const string Namespace = StorageNamespace;
	
	/// <inheritdoc />
	public VaultModule(ComponentResourceOptions? options = null) : base("vault", options)
	{
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var saBinding = new ClusterRoleBinding("vault-auth-delegator", new ClusterRoleBindingArgs
		{
			RoleRef = new RoleRefArgs
			{
				ApiGroup = "rbac.authorization.k8s.io",
				Kind = "ClusterRole",
				Name = "system:auth-delegator"
			},
			Subjects = new []
			{
				new SubjectArgs
				{
					Kind = "ServiceAccount",
					Name = "vault-operator",
					Namespace = Namespace
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
		
		var op = DeployOperator();

		// var configOp = DeployConfigurationOperator();
		
		var configDeps = ProvisionVaultConfig(op, config).Add(saBinding);

		var vault = DeployVault(op, config, configDeps);
		
		BootstrapJob(vault, config, configDeps);
	}
	
	private void BootstrapJob(Pulumi.Crds.Vault.V1Alpha1.Vault vault, Config config, InputList<Resource> args)
	{
		var crt64 = config.Require("CA/Vault/crt");
		var key64 = config.RequireSecret("CA/Vault/key");
		
		var crt = Encoding.UTF8.GetString(Convert.FromBase64String(crt64));
		var key = key64.Apply(x => Encoding.UTF8.GetString(Convert.FromBase64String(x)));
		
		var pemBundle = key.Apply(x => crt.TrimEnd('\n') + "\n" + x.TrimEnd('\n'));
		
		var bundleSecret = new Secret("pem-bundle", new SecretArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = Namespace
			},
			StringData = new InputMap<string>
			{
				{"bundle.pem", pemBundle}
			}
		}, new CustomResourceOptions
		{
			Parent = this,
			DependsOn = vault
		});

		args.Add(bundleSecret);
		args.Add(vault);

		var bootstrapJob = new Job("vault-bootstrap", new JobArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = Namespace
			},
			Spec = new JobSpecArgs
			{
				BackoffLimit = 6,
				Template = new PodTemplateSpecArgs
				{
					Spec = new PodSpecArgs
					{
						ServiceAccount = "vault-operator",
						RestartPolicy = "OnFailure",
						Containers = new []
						{
							new ContainerArgs
							{
								Name = "bootstrap",
								Image = "hashicorp/vault",
								Command =  new []
								{
									"/bin/sh"
								},
								Args = new []
								{
									"-c",
									"echo 'Authenticating' && " +
									"export VAULT_TOKEN=$(vault write -field=token auth/kubernetes/login role=bootstrapper jwt=$(cat /run/secrets/kubernetes.io/serviceaccount/token)) && " +
									"echo 'Saved vault token to var' && " +
									"vault write /pki/config/ca pem_bundle=@/vault/init/bundle/bundle.pem && " +
									"echo 'PKI provisioned'"
								},
								Env = new EnvVarArgs[]
								{
									new()
									{
										Name = "VAULT_ADDR",
										Value = $"http://vault.{Namespace}.svc.cluster.local:8200"
									},
									new()
									{
										Name = "VAULT_SKIP_VERIFY",
										Value = "false"
									}
								},
								VolumeMounts = new VolumeMountArgs[]
								{
									new()
									{
										Name = "vault-pem-bundle",
										MountPath = "/vault/init/bundle",
										ReadOnly = true
									}
								}
							}
						},
						Volumes = new VolumeArgs[]
						{
							new()
							{
								Name = "vault-pem-bundle",
								Secret = new SecretVolumeSourceArgs
								{
									SecretName = bundleSecret.Metadata.Apply(x => x.Name)
								}
							}
						}
					}
				}
			}
		}, new CustomResourceOptions
		{
			DependsOn = args,
			Parent = this
		});
	}
	
	private Pulumi.Crds.Vault.V1Alpha1.Vault DeployVault(Release operatorChart, Config config, InputList<Resource> args)
	{
		return new Pulumi.Crds.Vault.V1Alpha1.Vault("vault", new VaultArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Name = "vault",
				Namespace = operatorChart.Namespace.Apply(x => x)
			},
			Spec = new VaultSpecArgs
			{
				Size = 3,
				ServiceAccount = operatorChart.ResourceNames.Apply(x => x["ServiceAccount/v1"][0]),
				IstioEnabled = false,
				Ingress = ((config.GetBoolean("Traefik/OpenVaultPorts") ?? false) == false ? null : new VaultSpecIngressArgs
				{
					Annotations = new InputMap<string>
					{
						{"traefik.ingress.kubernetes.io/router.entrypoints", "web"}
					},
					Spec = new VaultSpecIngressSpecArgs
					{
						Rules = new []
						{
							new VaultSpecIngressSpecRulesArgs
							{
								Host = $"vault.{config.Require("DomainSuffix")}",
								Http = new VaultSpecIngressSpecRulesHttpArgs
								{
									Paths = new []
									{
										new VaultSpecIngressSpecRulesHttpPathsArgs
										{
											Path = "/",
											PathType = "Prefix",
											Backend = new VaultSpecIngressSpecRulesHttpPathsBackendArgs
											{
												Service = new VaultSpecIngressSpecRulesHttpPathsBackendServiceArgs
												{
													Name = "vault",
													Port = new VaultSpecIngressSpecRulesHttpPathsBackendServicePortArgs
													{
														Number = 8200
													}
												}
											}
										}
									}
								}
							}
						}
					}
				})!,
				UnsealConfig = new VaultSpecUnsealconfigArgs
				{
					Kubernetes = new VaultSpecUnsealconfigKubernetesArgs
					{
						SecretNamespace = operatorChart.Namespace.Apply(x => x),
						SecretName = "vault-unseal-keys"
					}
				},
				Config = new InputMap<object>
				{
					// ReSharper disable once StringLiteralTypo
					{"disable_mlock", true},
					{"storage", new InputMap<object>
						{
							{"raft", new InputMap<object>
								{
									{"path", "/vault/data"},
									{"ha_enabled", true}
								}
							}
						}
					},
					{"cluster_addr", "https://${.Env.POD_NAME}:8201"},
					{"api_addr", Output.Format($"https://${{.Env.POD_NAME}}.{operatorChart.Namespace}.svc.cluster.local:8200")},
					{"listener", new InputMap<object>
						{
							{"tcp", new InputMap<object>
								{
									{"address", "0.0.0.0:8200"},
									{"tls_disable", true},
									{"cluster_address", "0.0.0.0:8201"},
									{"telemetry", new InputMap<object>
										{
											{"unauthenticated_metrics_access", true}
										}
									}
								}
							}
						}
					},
					{"telemetry", new InputMap<object>
						{
							{"prometheus_retention_time", "30s"},
							{"disable_hostname", true}
						}
					},
					// {"service_registration", new InputMap<object>
					// 	{
					// 		{"kubernetes", new InputMap<object>()}
					// 	}
					// },
					{"ui", config.GetBoolean("Traefik/OpenVaultPorts") ?? false}
				},
				ExternalConfig = new InputMap<object>
				{
					{"purgeUnmanagedConfig", new InputMap<object>
					{
						{"enabled", false}
					}}
				},
				VaultEnvsConfig = new VaultSpecVaultenvsconfigArgs[]
				{
					new()
					{
						Name = "VAULT_LOG_LEVEL",
						Value = "debug"
					}
				},
				ServiceRegistrationEnabled = true,
				StatsdDisabled = true,
				ServiceMonitorEnabled = true,
				// FluentdEnabled = true,
				// FluentdConfig = 
				VolumeMounts = new []
				{
					new VaultSpecVolumemountsArgs
					{
						Name = "vault-raft",
						MountPath = "/vault/data"
					}
				},
				VolumeClaimTemplates = new []
				{
					new VaultSpecVolumeclaimtemplatesArgs
					{
						Metadata = new VaultSpecVolumeclaimtemplatesMetadataArgs
						{
							Name = "vault-raft"
						},
						Spec = new VaultSpecVolumeclaimtemplatesSpecArgs
						{
							AccessModes = new []{"ReadWriteOnce"},
							VolumeMode = "Filesystem",
							Resources = new VaultSpecVolumeclaimtemplatesSpecResourcesArgs
							{
								Requests = new InputMap<Union<int, string>>
								{
									{"storage", "1Gi"}
								}
							},
						}
					}
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this,
			DependsOn = args
		});
	}

	private ImmutableArray<Resource> ProvisionVaultConfig(Release operatorChart, Config config)
	{
		var pkiConfigRaw = File.ReadAllText("./Modules/Vault/pki.yaml");
		var pkiConfig = Output.Format(FormattableStringFactory.Create(
			pkiConfigRaw,
			Output.Format($"https://vault.{operatorChart.Namespace}.svc.cluster.local:8200/v1/pki"),
			config.Require("DomainSuffix")
		));
		
		return new List<Resource>(2)
		{
			ProvisionConfigMap(operatorChart, "vault-defaults", File.ReadAllText("./Modules/Vault/defaults.yaml")),
			ProvisionConfigMap(operatorChart, "vault-pki", pkiConfig)
		}.ToImmutableArray();
	}

	private Resource ProvisionConfigMap(Release operatorChart, string name, Input<string> data)
	{
		return new ConfigMap(name, new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Name = name,
				Namespace = operatorChart.Namespace,
				Labels = new InputMap<string>
				{
					{ "app.kubernetes.io/name", "vault-configurator" },
					{ "vault_cr", "vault" },
				}
			},
			Data = new InputMap<string>
			{
				{
					"vault-config.yml", data
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}

	private Release DeployOperator()
	{
		var values = new Dictionary<string, object>
		{
			["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true
					}
				},
			["monitoring"] = new Dictionary<string, object>
			{
				["serviceMonitor"] = new Dictionary<string, object>
				{
					["enabled"] = true
				}
			},
			["unsealer"] = new Dictionary<string, object>
			{
				["metrics"] = new Dictionary<string, object>
				{
					["serviceMonitor"] = new Dictionary<string, object>
					{
						["enabled"] = true
					}
				}
			}
		};
		
		return CreateHelmRelease(
			"vault-operator",
			"vault-operator",
			"https://kubernetes-charts.banzaicloud.com",
			Namespace, val: values);
	}
}