// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs>? _matchExpressions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs>? _matchFields;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs>());
            set => _matchFields = value;
        }

        public VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs()
        {
        }
        public static new VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs Empty => new VaultSpecVaultconfigurerpodspecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs();
    }
}
