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
    public sealed class VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesConfigmap
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesConfigmapItems> Items;
        public readonly string Name;
        public readonly bool Optional;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesConfigmap(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecVolumesProjectedSourcesConfigmapItems> items,

            string name,

            bool optional)
        {
            Items = items;
            Name = name;
            Optional = optional;
        }
    }
}
