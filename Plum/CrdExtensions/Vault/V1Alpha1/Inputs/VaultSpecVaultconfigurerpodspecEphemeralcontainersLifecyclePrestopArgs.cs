// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopArgs : global::Pulumi.ResourceArgs
    {
        [Input("exec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopExecArgs>? Exec { get; set; }

        [Input("httpGet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopHttpgetArgs>? HttpGet { get; set; }

        [Input("tcpSocket")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopTcpsocketArgs>? TcpSocket { get; set; }

        public VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopArgs Empty => new VaultSpecVaultconfigurerpodspecEphemeralcontainersLifecyclePrestopArgs();
    }
}
