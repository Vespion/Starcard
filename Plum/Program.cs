using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Plum;
using Plum.Modules;
using Pulumi;
using Pulumi.Command.Local;
using Pulumi.Kubernetes;
using Pulumi.Kubernetes.Types.Inputs.Provider;
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
               "--agents 3 -p 8000:80@loadbalancer -p 8001:443@loadbalancer -p 5433:5432@loadbalancer " +
               $"--volume \"{store}:/var/lib/rancher/k3s/storage@all\" --k3s-arg \"--disable=traefik@server:*\" ",
            Delete = "k3d cluster delete starcard"
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
            DeleteUnreachable = config.GetBoolean("k8s:DeleteUnreachable") ?? false,
            HelmReleaseSettings = new HelmReleaseSettingsArgs
            {
               Driver = "configmap"
            }, EnableServerSideApply = true
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
      Provider = kubeProvider
   });
   
   Log.Info("Deploying SeaweedFS");
   var seaweed = new SeaweedModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         certManager,
         monitoring
      },
      Provider = kubeProvider
   });
   
   var network = new NetworkModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         monitoring
      },
      Provider = kubeProvider
   });
   
   //TODO Deploy vault stack
   var vault = new VaultModule(new ComponentResourceOptions
   {
      DependsOn =
      {
         monitoring
      },
      Provider = kubeProvider
   });
   
   // Export outputs here
   return new Dictionary<string, object?>
   {
      ["localCluster"] = config.Get("ClusterType") == "k3d"
      // ["outputKey"] = "outputValue"
   };
});
