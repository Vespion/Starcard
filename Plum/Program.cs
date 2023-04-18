using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Plum;
using Plum.Modules;
using Plum.Modules.Databases;
using Pulumi;
using Pulumi.Command.Local;
using Pulumi.Crds.Monitoring.V1;
using Pulumi.Kubernetes;
using Pulumi.Kubernetes.Types.Inputs.Meta.V1;
using Pulumi.Kubernetes.Types.Inputs.Monitoring.V1;
using Config = Pulumi.Config;

Provider CreateKubeProvider(Config config)
{
   switch (config.Get("ClusterType"))
   {
      case "k3d":
         Log.Info("Creating k3d cluster");
         var store = Path.GetFullPath("./.cluster/store");
         Directory.CreateDirectory(store);
         
         var cluster = new Command("k3d-cluster", new CommandArgs
         {
            Create =
               "k3d cluster create starcard --kubeconfig-update-default=false --kubeconfig-switch-context=false --servers 1 " +
               "--agents 3 --k3s-arg \"--disable=traefik@server:*\" " +
               $"-p {config.RequireInt32("Traefik/Ports/Http")}:{config.RequireInt32("Traefik/Ports/Http")}@loadbalancer " +
               $"-p {config.RequireInt32("Traefik/Ports/Https")}:{config.RequireInt32("Traefik/Ports/Https")}@loadbalancer " +
               $"-p {config.RequireInt32("Traefik/Ports/Orleans")}:{config.RequireInt32("Traefik/Ports/Orleans")}@loadbalancer " +
               $"--volume \"{store}:/var/lib/rancher/k3s/storage@all\" ",
            Delete = "k3d cluster delete starcard"
         }, new CustomResourceOptions
         {
            IgnoreChanges =
            {
               "create"
            }
         });

         var nodeConfig = new Command("export-k3d-config", new CommandArgs
         {
            Create = "k3d kubeconfig get starcard > ./.cluster/kubeconfig",
            Delete = "rm -r ./.cluster"
         }, new CustomResourceOptions
         {
            DependsOn =
            {
               cluster
            }
         });
         
         Log.Debug("Creating provider from k3d kubeconfig");
         return new Provider("k3d-provider", new ProviderArgs
         {
            KubeConfig = "./.cluster/kubeconfig",
            DeleteUnreachable = config.GetBoolean("k8s:DeleteUnreachable") ?? true,
            EnableServerSideApply = true
         }, new CustomResourceOptions
         {
            DependsOn =
            {
               nodeConfig
            }
         });
         break;
      default:
         throw new ArgumentException("Invalid cluster type");
   }
}

return await Deployment.RunAsync(async () =>
{
   var config = new Config();

   if (config.GetBoolean("WaitForDebugger") ?? false)
   {
      Log.Info("WaitForDebugger is true, checking for debugger");
      if (!Debugger.IsAttached)
      {
         Log.Warn("Debugger is not attached. Launching debugger...");
         Debugger.Launch();
         
         Log.Info("Waiting for debugger to attach");
         const int sleep = 1000; //1 second
         var totalSleep = 0;
         while (!Debugger.IsAttached)
         {
            Log.Debug("Waiting for debugger to attach...");
            await Task.Delay(sleep);
            totalSleep += sleep;

            if (totalSleep > 120000) //120 seconds
            {
               var ex = new TimeoutException("Timed out waiting for debugger to attach");
               Log.Exception(ex);
               throw ex;
            }
         }
      }

      Debugger.Break();
   }
      
   
   // Add your resources here
   // e.g. var resource = new Resource("name", new ResourceArgs { });
   Log.Info("Creating kubernetes provider");
   var kubeProvider = CreateKubeProvider(config);

   Log.Info("Deploying cert-manager");
   var certManager = new CertManagerModule(new ComponentResourceOptions
   {
      Provider = kubeProvider
   });
   
   Log.Info("Deploy monitoring stack");
   var monitoring = new MonitoringModule(new ComponentResourceOptions
   {
      Provider = kubeProvider,
      DependsOn =
      {
         certManager
      }
   });

   var logging = new LoggingModule(new ComponentResourceOptions
   {
      Provider = kubeProvider
   });

   var certManagerMonitor = new ServiceMonitor("cert-manager-monitor", new ServiceMonitorArgs
   {
      Metadata = new ObjectMetaArgs
      {
         Namespace = ComponentModule.NetworkNamespace,
         Labels = 
         {
            ["app"] = "cert-manager",
            ["app.kubernetes.io/name"] = "cert-manager",
            ["app.kubernetes.io/instance"] = "cert-manager",
            ["app.kubernetes.io/component"] = "controller",
            ["prometheus"] = "kube-prometheus"
         }
      },
      Spec = new ServiceMonitorSpecArgs
      {
         JobLabel = "cert-manager",
         Selector = new ServiceMonitorSpecSelectorArgs
         {
            MatchLabels = new Dictionary<string, string>
            {
               ["app.kubernetes.io/name"] = "cert-manager",
               ["app.kubernetes.io/instance"] = "cert-manager",
               ["app.kubernetes.io/component"] = "controller"
            }
         },
         NamespaceSelector = new ServiceMonitorSpecNamespaceselectorArgs
         {
            MatchNames = new []
            {
               ComponentModule.NetworkNamespace
            }
         },
         Endpoints = new ServiceMonitorSpecEndpointsArgs[]
         {
            new()
            {
               TargetPort = 9402,
               Path = "/metrics",
               Interval = "60s",
               ScrapeTimeout = "30s",
               HonorLabels = false
            }
         }
      }
   }, new CustomResourceOptions
   {
      Provider = kubeProvider,
      DependsOn =
      {
         logging,
         monitoring
      }
   });
   
   Log.Info("Deploying SeaweedFS");
   var seaweed = new SeaweedModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         certManager,
         logging,
         monitoring
      },
      Provider = kubeProvider
   });
   
   var network = new NetworkModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         certManager,
         logging,
         monitoring
      },
      Provider = kubeProvider
   });
   
   var vault = new VaultModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         certManager,
         logging,
         monitoring
      },
      Provider = kubeProvider
   });

   var db = new DatabaseModule(new ComponentResourceOptions
   {
      Provider = kubeProvider,
      DependsOn =
      {
         certManager,
         monitoring,
         network
      }
   });
   
   //TODO Deploy apps
   
   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["localCluster"] = config.Get("ClusterType") == "k3d"
      // ["outputKey"] = "outputValue"
   };
});
