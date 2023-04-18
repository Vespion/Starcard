using System;
using System.Collections.Generic;
using Plum.Modules;
using Pulumi;
using Pulumi.Crds.Certmanager.V1;
using Pulumi.Kubernetes.Core.V1;
using Pulumi.Kubernetes.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Certmanager.V1;
using Pulumi.Kubernetes.Types.Inputs.Core.V1;
using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;

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
	protected internal const string NetworkNamespace = "comms";
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
			CleanupOnFail = true,
			SkipAwait = skipAwait,
			WaitForJobs = true,
			Values = val ?? new InputMap<object>(),
			ReuseValues = reuseValues
		};
	}

	protected Dictionary<string, object> BuildIngressConfig(Config config, string subdomain, string ns,
		string entrypoint = "websecure",
		bool enabled = true,
		bool host = true, string? className = null)
	{
		var fullDomain = $"{subdomain}.{config.Require("DomainSuffix")}";

		var cert = BuildCertificate(config, subdomain, ns);
		
		var vals = new Dictionary<string, object>
		{
			["enabled"] = enabled,
			["hosts"] = new[] { fullDomain },
			["className"] = null!,
			["annotations"] = new Dictionary<string, string>
			{
				["traefik.ingress.kubernetes.io/router.entrypoints"] = entrypoint
			},
			["tls"] = new Dictionary<string, object>[]
			{
				new()
				{
					["secretName"] = cert.Spec.Apply(x => x.SecretName),
					["hosts"] = Array.Empty<object>()
				}
			}
		};

		if (host)
		{
			vals["host"] = fullDomain;
		}

		return vals;
	}

	protected ConfigMap CreateGrafanaDashboard(string name, Input<string> ns, Input<string> fileName)
	{
		return new ConfigMap($"{name}-dash-config", new ConfigMapArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Namespace = ns,
				Labels = new InputMap<string>
				{
					{ "grafana_dashboard", "1" }
				}
			},
			Data = new InputMap<string>
			{
				{ $"{name}.json", fileName.Apply(x => System.IO.File.ReadAllText($"./Dashboards/{x}.json")) }
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}
	
	protected Certificate BuildCertificate(Config config, string subdomain, string ns)
	{
		var domain = $"{subdomain}.{config.Require("DomainSuffix")}";
		return new Certificate($"{subdomain}-ingress-tls", new CertificateArgs
		{
			Metadata = new ObjectMetaArgs
			{
				Name = subdomain,
				Namespace = ns
			},
			Spec = new CertificateSpecArgs
			{
				SecretName = $"{domain}-ingress-tls",
				DnsNames = new InputList<string>
				{
					domain
				},
				IsCA = false,
				Usages = new []
				{
					"server auth",
					"client auth"
				},
				Duration = "2h",
				RenewBefore = "1h",
				PrivateKey = new CertificateSpecPrivatekeyArgs
				{
					RotationPolicy = "Always",
					Size = 521,
					Algorithm = "ECDSA",
					Encoding = "PKCS1"
				},
				IssuerRef = new CertificateSpecIssuerrefArgs
				{
					Name = CertManagerModule.WebIssuer,
					Kind = "ClusterIssuer"
				}
			}
		}, new CustomResourceOptions
		{
			Parent = this
		});
	}
}