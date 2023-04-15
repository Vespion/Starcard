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
    public sealed class VaultSpecVolumesConfigmap
    {
        public readonly int DefaultMode;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVolumesConfigmapItems> Items;
        public readonly string Name;
        public readonly bool Optional;

        [OutputConstructor]
        private VaultSpecVolumesConfigmap(
            int defaultMode,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVolumesConfigmapItems> items,

            string name,

            bool optional)
        {
            DefaultMode = defaultMode;
            Items = items;
            Name = name;
            Optional = optional;
        }
    }
}
