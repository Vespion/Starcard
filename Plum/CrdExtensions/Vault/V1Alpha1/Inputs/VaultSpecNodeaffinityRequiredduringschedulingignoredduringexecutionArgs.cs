// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionArgs : global::Pulumi.ResourceArgs
    {
        [Input("nodeSelectorTerms", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>? _nodeSelectorTerms;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs> NodeSelectorTerms
        {
            get => _nodeSelectorTerms ?? (_nodeSelectorTerms = new InputList<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>());
            set => _nodeSelectorTerms = value;
        }

        public VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionArgs()
        {
        }
        public static new VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionArgs Empty => new VaultSpecNodeaffinityRequiredduringschedulingignoredduringexecutionArgs();
    }
}