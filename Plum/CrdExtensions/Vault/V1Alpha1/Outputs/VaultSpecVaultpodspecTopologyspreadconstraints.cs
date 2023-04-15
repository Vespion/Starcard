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
    public sealed class VaultSpecVaultpodspecTopologyspreadconstraints
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraintsLabelselector LabelSelector;
        public readonly int MaxSkew;
        public readonly string TopologyKey;
        public readonly string WhenUnsatisfiable;

        [OutputConstructor]
        private VaultSpecVaultpodspecTopologyspreadconstraints(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultpodspecTopologyspreadconstraintsLabelselector labelSelector,

            int maxSkew,

            string topologyKey,

            string whenUnsatisfiable)
        {
            LabelSelector = labelSelector;
            MaxSkew = maxSkew;
            TopologyKey = topologyKey;
            WhenUnsatisfiable = whenUnsatisfiable;
        }
    }
}
