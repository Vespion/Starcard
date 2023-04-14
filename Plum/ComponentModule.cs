using System.Diagnostics.Contracts;
using Pulumi;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;

namespace Plum;

public abstract class ComponentModule : ComponentResource
{
	/// <summary>
	/// Designed for app resources that are not considered infrastructure.
	/// </summary>
	protected const string AppNamespace = "default";
	/// <summary>
	/// Designed for resources that manage storage.
	/// </summary>
	protected const string StorageNamespace = "storage";
	/// <summary>
	/// Designed for networking and communication resources.
	/// </summary>
	protected const string NetworkNamespace = "comms";
	/// <summary>
	/// Designed for resources that manage metrics, logs and other telemetry.
	/// </summary>
	protected const string MonitoringNamespace = "monitoring";

	/// <inheritdoc />
	public ComponentModule(string name, ComponentResourceOptions? options = null) : base("vespion:starcard:module", name, options)
	{
		var config = new Config();
		
		RegisterResources(config);
		
		RegisterOutputs();
	}
	
	protected abstract void RegisterResources(Config config);
	
	protected Release CreateHelmRelease(string name, Input<string> chart, Input<string>? repo, Input<string> ns,
		string? version = null, Input<string>? releaseName = null, InputMap<object>? val = null, Input<bool>? reuseValues = null,
		bool skipAwait = false,
		params Resource[] deps)
	{
		releaseName ??= name;
		return new Release(name, CreateHelmReleaseArgs(name, chart, repo, ns, version, releaseName, val, reuseValues, skipAwait), new CustomResourceOptions
		{
			DependsOn = deps,
			Parent = this
		});
	}
	
	protected ReleaseArgs CreateHelmReleaseArgs(string name, Input<string> chart, Input<string>? repo, Input<string> ns,
		string? version = null, Input<string>? releaseName = null, InputMap<object>? val = null, Input<bool>? reuseValues = null, bool skipAwait = false)
	{
		releaseName ??= name;
		return new ReleaseArgs
		{
			RepositoryOpts = repo == null ? null! : new RepositoryOptsArgs
			{
				Repo = repo
			},
			Chart = chart,
			Version = version!,
			Name = releaseName,
			Namespace = ns,
			CreateNamespace = true,
			Atomic = true,
			CleanupOnFail = true,
			SkipAwait = skipAwait,
			WaitForJobs = true,
			Values = val ?? new InputMap<object>(),
			ReuseValues = reuseValues
		};
	}
}