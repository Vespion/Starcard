// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1
{

    public class VaultSpecVaultpodspecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionArgs : global::Pulumi.ResourceArgs
    {
        [Input("podAffinityTerm", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Vault.V1Alpha1.VaultSpecVaultpodspecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionPodaffinitytermArgs> PodAffinityTerm { get; set; } = null!;

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public VaultSpecVaultpodspecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionArgs()
        {
        }
        public static new VaultSpecVaultpodspecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionArgs Empty => new VaultSpecVaultpodspecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionArgs();
    }
}
