// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecVolumesHostpathArgs : global::Pulumi.ResourceArgs
    {
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        public VaultSpecVaultpodspecVolumesHostpathArgs()
        {
        }
        public static new VaultSpecVaultpodspecVolumesHostpathArgs Empty => new VaultSpecVaultpodspecVolumesHostpathArgs();
    }
}
