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
    public sealed class VaultSpecVolumesProjectedSourcesSecret
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVolumesProjectedSourcesSecretItems> Items;
        public readonly string Name;
        public readonly bool Optional;

        [OutputConstructor]
        private VaultSpecVolumesProjectedSourcesSecret(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVolumesProjectedSourcesSecretItems> items,

            string name,

            bool optional)
        {
            Items = items;
            Name = name;
            Optional = optional;
        }
    }
}