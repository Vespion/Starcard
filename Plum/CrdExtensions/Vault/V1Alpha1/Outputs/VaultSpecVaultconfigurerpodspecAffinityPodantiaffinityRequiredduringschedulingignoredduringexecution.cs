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
    public sealed class VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselector LabelSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionNamespaceselector NamespaceSelector;
        public readonly ImmutableArray<string> Namespaces;
        public readonly string TopologyKey;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionLabelselector labelSelector,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodantiaffinityRequiredduringschedulingignoredduringexecutionNamespaceselector namespaceSelector,

            ImmutableArray<string> namespaces,

            string topologyKey)
        {
            LabelSelector = labelSelector;
            NamespaceSelector = namespaceSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}
