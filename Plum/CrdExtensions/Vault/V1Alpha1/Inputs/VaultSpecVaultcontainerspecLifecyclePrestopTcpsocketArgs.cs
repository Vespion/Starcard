// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultcontainerspecLifecyclePrestopTcpsocketArgs : global::Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("port", required: true)]
        public InputUnion<int, string> Port { get; set; } = null!;

        public VaultSpecVaultcontainerspecLifecyclePrestopTcpsocketArgs()
        {
        }
        public static new VaultSpecVaultcontainerspecLifecyclePrestopTcpsocketArgs Empty => new VaultSpecVaultcontainerspecLifecyclePrestopTcpsocketArgs();
    }
}
