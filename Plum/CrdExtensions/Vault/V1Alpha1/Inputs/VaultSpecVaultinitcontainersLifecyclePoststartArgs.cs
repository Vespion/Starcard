// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultinitcontainersLifecyclePoststartArgs : global::Pulumi.ResourceArgs
    {
        [Input("exec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultinitcontainersLifecyclePoststartExecArgs>? Exec { get; set; }

        [Input("httpGet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultinitcontainersLifecyclePoststartHttpgetArgs>? HttpGet { get; set; }

        [Input("tcpSocket")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultinitcontainersLifecyclePoststartTcpsocketArgs>? TcpSocket { get; set; }

        public VaultSpecVaultinitcontainersLifecyclePoststartArgs()
        {
        }
        public static new VaultSpecVaultinitcontainersLifecyclePoststartArgs Empty => new VaultSpecVaultinitcontainersLifecyclePoststartArgs();
    }
}
