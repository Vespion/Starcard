using Pulumi;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;

namespace Plum.Modules;

public class CertManagerModule: ComponentModule
{
	/// <inheritdoc />
	public CertManagerModule(ComponentResourceOptions? options = null) : base("cert-manager", options)
	{
		
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var release = DeployChart();
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