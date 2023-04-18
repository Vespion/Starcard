using Pulumi;
using Pulumi.Crds.Certmanager.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Certmanager.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

namespace Plum.Modules;

public class CertManagerModule: ComponentModule
{
	public const string WebIssuer = "web-issuer";
	public const string DbIssuer = "db-issuer";

	/// <inheritdoc />
	public CertManagerModule(ComponentResourceOptions? options = null) : base("cert-manager", options)
	{
		
	}

	private void DeployIssuers(Release certManager)
	{
		var saToken = new Secret("cert-manager-sa-token", new SecretArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = NetworkNamespace,
				Annotations = new InputMap<string>
				{
					["kubernetes.io/service-account.name"] = "cert-manager"
				}
			},
			Type = "kubernetes.io/service-account-token"
		}, new CustomResourceOptions
		{
			DependsOn =
			{
				certManager
			},
			Parent = this
		});

		ClusterIssuer DeployIssuer(string role, string name)
		{
			return new ClusterIssuer(name, new ClusterIssuerArgs
			{
				Metadata = new ObjectMetaArgs
				{
					Name = name,
					Namespace = NetworkNamespace
				},
				Spec = new ClusterIssuerSpecArgs
				{
					Vault = new ClusterIssuerSpecVaultArgs
					{
						Server = $"http://vault.{StorageNamespace}.svc.cluster.local:8200",
						Path = $"pki/sign/{role}",
						Auth = new ClusterIssuerSpecVaultAuthArgs
						{
							Kubernetes = new ClusterIssuerSpecVaultAuthKubernetesArgs
							{
								Role = "cert-manager",
								SecretRef = new ClusterIssuerSpecVaultAuthKubernetesSecretrefArgs
								{
									Name = saToken!.Metadata.Apply(x => x.Name),
									Key = "token"
								}
							}
						}
					}
				}
			}, new CustomResourceOptions
			{
				DependsOn =
				{
					certManager
				},
				Parent = this
			});
		}

		_ = DeployIssuer("web", WebIssuer);
		_ = DeployIssuer("db", DbIssuer);
	}
	
	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var release = DeployChart();
		
		DeployIssuers(release);
	}

	private Release DeployChart()
	{
		var values = new InputMap<object>
		{
			["installCRDs"] = true,
			["prometheus"] = new InputMap<object>
			{
				["enabled"] = true,
				["servicemonitor"] = new InputMap<object>
				{
					["enabled"] = false //Not installed yet
				}
			}
		};
		
		return CreateHelmRelease(
			"cert-manager",
			"cert-manager",
			"https://charts.jetstack.io",
			NetworkNamespace,
			val: values);
	}
}