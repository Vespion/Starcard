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
    public sealed class VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesDownwardapi
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesDownwardapiItems> Items;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesDownwardapi(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesDownwardapiItems> items)
        {
            Items = items;
        }
    }
}
