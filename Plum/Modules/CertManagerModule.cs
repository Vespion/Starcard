using Pulumi;
using Pulumi.Crds.Certmanager.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Certmanager.V1;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

namespace Plum.Modules;

public class CertManagerModule: ComponentModule
{
	/// <inheritdoc />
	public CertManagerModule(ComponentResourceOptions? options = null) : base("cert-manager", options)
	{
		
	}

	internal const string InternalIssuerName = "internal-issuer";

	internal const string InternalIssuerType = "ClusterIssuer";

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var release = DeployChart();
		DeployInternalIssuer(release);
	}
	
	private void DeployInternalIssuer(Release release)
	{
		var issuer = new ClusterIssuer("internal-issuer", new ClusterIssuerArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Name = InternalIssuerName,
				Namespace = "kube-system"
			},
			Spec = new ClusterIssuerSpecArgs
			{
				SelfSigned = new ClusterIssuerSpecSelfsignedArgs
				{
					
				}
			}
		}, new CustomResourceOptions
		{
			DependsOn =
			{
				release
			},
			Parent = this
		});
		
	}

	private Release DeployChart()
	{
		return new Release("cert-manager", new ReleaseArgs
		{
			Namespace = NetworkNamespace,
			Chart = "cert-manager",
			Name = "cert-manager",
			RepositoryOpts = new RepositoryOptsArgs
			{
				Repo = "https://charts.jetstack.io"
			},
			Values = new InputMap<object>
			{
				{"installCRDs", true}
			},
			WaitForJobs = true,
			CreateNamespace = true
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}
}