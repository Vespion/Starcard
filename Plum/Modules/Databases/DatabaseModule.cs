using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Pulumi.Crds.Certmanager.V1;
using Pulumi.Crds.Monitoring.V1;
using Pulumi.Crds.Postgresql.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Certmanager.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Monitoring.V1;
using Pulumi.Kubernetes.Types.Inputs.Postgresql.V1;

namespace Plum.Modules.Databases;

public class DatabaseModule: ComponentModule
{
	/// <inheritdoc />
	public DatabaseModule(ComponentResourceOptions? options = null, string? name = null) : base(name == null ? "database": $"database/{name}", options)
	{
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var op = DeployOperator();
		
		_ = new OrleansDatabase(new ComponentResourceOptions
		{
			Parent = this,
			DependsOn =
			{
				op
			}
		});

		//TODO Deploy identity db

		//TODO Deploy event store?

		//TODO Link vault up at some point
	}

	protected Cluster DeployCluster(string name, ConfigMap initMap, string[] configKeyOrder)
	{
		// var serverCert = new Certificate($"{name}-server-cert", new CertificateArgs
		// {
		// 	Metadata = new ObjectMetaArgs
		// 	{
		// 		Namespace = ns
		// 	},
		// 	Spec = new CertificateSpecArgs
		// 	{
		// 		SecretName = $"{name}-server-cert-secret",
		// 		SecretTemplate = new CertificateSpecSecrettemplateArgs
		// 		{
		// 			Labels = new InputMap<string>
		// 			{
		// 				{ "cnpg.io/reload", "" }
		// 			}
		// 		},
		// 		Usages = new []
		// 		{
		// 			"server auth"
		// 		},
		// 		DnsNames = new []
		// 		{
		// 			$"{name}-rw",
		// 			$"{name}-rw.{ns}",
		// 			$"{name}-rw.{ns}.svc",
		// 			$"{name}-rw.{ns}.svc.cluster.local",
		// 			$"{name}-ro",
		// 			$"{name}-ro.{ns}",
		// 			$"{name}-ro.{ns}.svc",
		// 			$"{name}-ro.{ns}.svc.cluster.local",
		// 			$"{name}-r",
		// 			$"{name}-r.{ns}",
		// 			$"{name}-r.{ns}.svc",
		// 			$"{name}-r.{ns}.svc.cluster.local"
		// 		},
		// 		PrivateKey = new CertificateSpecPrivatekeyArgs
		// 		{
		// 			RotationPolicy = "Always",
		// 			Size = 521,
		// 			Algorithm = "ECDSA",
		// 			Encoding = "PKCS1"
		// 		},
		// 		IssuerRef = new CertificateSpecIssuerrefArgs
		// 		{
		// 			Name = CertManagerModule.DbIssuer,
		// 			Kind = "ClusterIssuer"
		// 		}
		// 	}
		// }, new CustomResourceOptions
		// {
		// 	Parent = this
		// });
		//
		// var clientCert = new Certificate($"{name}-client-cert", new CertificateArgs
		// {
		// 	Metadata = new ObjectMetaArgs
		// 	{
		// 		Namespace = ns
		// 	},
		// 	Spec = new CertificateSpecArgs
		// 	{
		// 		SecretName = $"{name}-client-cert-secret",
		// 		SecretTemplate = new CertificateSpecSecrettemplateArgs
		// 		{
		// 			Labels = new InputMap<string>
		// 			{
		// 				{ "cnpg.io/reload", "true" }
		// 			}
		// 		},
		// 		Usages = new []
		// 		{
		// 			"client auth"
		// 		},
		// 		CommonName = "streaming_replica",
		// 		PrivateKey = new CertificateSpecPrivatekeyArgs
		// 		{
		// 			RotationPolicy = "Always",
		// 			Size = 521,
		// 			Algorithm = "ECDSA",
		// 			Encoding = "PKCS1"
		// 		},
		// 		IssuerRef = new CertificateSpecIssuerrefArgs
		// 		{
		// 			Name = CertManagerModule.DbIssuer,
		// 			Kind = "ClusterIssuer"
		// 		}
		// 	}
		// }, new CustomResourceOptions
		// {
		// 	Parent = this
		// });
		
		return new Cluster(name, new ClusterArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = StorageNamespace
			},
			Spec = new ClusterSpecArgs
			{
				Description = "Backing store for Orleans",
				Instances = 3,
				Storage = new ClusterSpecStorageArgs
				{
					Size = "2Gi"
				},
				Monitoring = new ClusterSpecMonitoringArgs
				{
					EnablePodMonitor = true
				},
				// Certificates = new ClusterSpecCertificatesArgs
				// {
				// 	ServerCASecret = $"{name}-server-cert-secret",
				// 	ServerTLSSecret = $"{name}-server-cert-secret",
				// 	ClientCASecret = $"{name}-client-cert-secret",
				// 	ReplicationTLSSecret = $"{name}-client-cert-secret"
				// },
				EnableSuperuserAccess = false,
				Bootstrap = new ClusterSpecBootstrapArgs
				{
					Initdb = new ClusterSpecBootstrapInitdbArgs
					{
						Database = name,
						PostInitSQL = new []
						{
							//Provision vault user
							"CREATE USER vault WITH INHERIT CREATEROLE ENCRYPTED PASSWORD 'bootstrapper-password-rotate-me-!!' IN ROLE pg_signal_backend;",
						},
						PostInitApplicationSQLRefs = new ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsArgs
						{
							ConfigMapRefs = configKeyOrder
								.Select(k => new ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsConfigmaprefsArgs
								{
									Key = k,
									Name = initMap.Metadata.Apply(m => m.Name)
								})
								.ToArray()
						}
					}
				},
				// Backup = new ClusterSpecBackupArgs
				// {
				// 	BarmanObjectStore = new ClusterSpecBackupBarmanobjectstoreArgs
				// 	{
				// 		DestinationPath = "s3://db-backups/orleans",
				// 		EndpointURL = $"http://seaweedfs-s3.{StorageNamespace}.svc.cluster.local:8333",
				// 		S3Credentials = new ClusterSpecBackupBarmanobjectstoreS3credentialsArgs
				// 		{
				// 			SecretAccessKey = "any_no_empty_key",
				// 			AccessKeyId = new ClusterSpecBackupBarmanobjectstoreS3credentialsAccesskeyidArgs
				// 			{
				// 				Name = "seaweedfs-s3-secret",
				// 				
				// 			}
				// 		}
				// 	}
				// }
			}
		}, new CustomResourceOptions
		{
			DependsOn =
			{
				// clientCert,
				// serverCert
			},
			Parent = this
		});
	}
	
	protected ConfigMap DeployInitConfigMap(string name, Dictionary<string, string> data)
	{
		return new ConfigMap(name, new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = StorageNamespace
			},
			Data = data
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}

	private Release DeployOperator()
	{
		_ = new PodMonitor("cnpg-operator-pod-monitor", new PodMonitorArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = StorageNamespace
			},
			Spec = new PodMonitorSpecArgs
			{
				PodMetricsEndpoints = new PodMonitorSpecPodmetricsendpointsArgs[]
				{
					new()
					{
						Port = "metrics"
					}
				},
				Selector = new PodMonitorSpecSelectorArgs
				{
					MatchLabels = new Dictionary<string, string>
					{
						{ "app.kubernetes.io/name", "cloudnative-pg" }
					}
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});

		return CreateHelmRelease(
			"cnpg-operator",
			"cloudnative-pg",
			"https://cloudnative-pg.github.io/charts",
			StorageNamespace
		);
	}
}