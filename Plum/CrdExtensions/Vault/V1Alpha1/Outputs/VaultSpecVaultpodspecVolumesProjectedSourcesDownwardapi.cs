// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1
{

    [OutputType]
    public sealed class VaultSpecVaultpodspecVolumesProjectedSourcesDownwardapi
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesProjectedSourcesDownwardapiItems> Items;

        [OutputConstructor]
        private VaultSpecVaultpodspecVolumesProjectedSourcesDownwardapi(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecVolumesProjectedSourcesDownwardapiItems> items)
        {
            Items = items;
        }
    }
}
