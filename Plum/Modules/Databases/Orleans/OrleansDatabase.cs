using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pulumi;
using Pulumi.Crds.Traefik.V1Alpha1;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1;

namespace Plum.Modules.Databases;

public class OrleansDatabase : DatabaseModule
{
	public OrleansDatabase(ComponentResourceOptions? options = null) : base(options, "orleans")
	{
	}

	/// <inheritdoc />
	protected override void RegisterResources(Config config)
	{
		var initConfigValues = new Dictionary<string, string>
		{
			{ "init.sql", File.ReadAllText("./Modules/Databases/Orleans/PostgreSQL-Main.sql") },
			{ "reminders.sql", File.ReadAllText("./Modules/Databases/Orleans/PostgreSQL-Reminders.sql") },
			{ "persistence.sql", File.ReadAllText("./Modules/Databases/Orleans/PostgreSQL-Persistence.sql") },
			{ "clustering.sql", File.ReadAllText("./Modules/Databases/Orleans/PostgreSQL-Clustering.sql") },
		};
		var initConfig = DeployInitConfigMap("orleans-init", initConfigValues);

		var db = DeployCluster("orleans", initConfig, initConfigValues.Keys.ToArray());

		if (config.GetBoolean("Traefik/Db/OpenOrleansPorts") ?? false)
		{
			var ingress = new IngressRouteTCP("orleans-ingress", new IngressRouteTCPArgs
			{
				Metadata = new ObjectMetaArgs
				{
					Namespace = StorageNamespace
				},
				Spec = new IngressRouteTCPSpecArgs
				{
					EntryPoints = new []
					{
						"orleans"
					},
					Routes = new IngressRouteTCPSpecRoutesArgs[]
					{
						new()
						{
							Match = "HostSNI(`*`)",
							Services = new IngressRouteTCPSpecRoutesServicesArgs[]
							{
								new()
								{
									Name = "orleans-rw",
									Port = 5432
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
	}
}