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
    public sealed class VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecution
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector LabelSelector;
        public readonly Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionNamespaceselector NamespaceSelector;
        public readonly ImmutableArray<string> Namespaces;
        public readonly string TopologyKey;

        [OutputConstructor]
        private VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector labelSelector,

            Pulumi.Kubernetes.Types.Outputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionNamespaceselector namespaceSelector,

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
