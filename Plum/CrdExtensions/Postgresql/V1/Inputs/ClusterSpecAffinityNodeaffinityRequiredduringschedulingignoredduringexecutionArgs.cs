// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Postgresql.V1
{

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
    /// </summary>
    public class ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs : global::Pulumi.ResourceArgs
    {
        [Input("nodeSelectorTerms", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>? _nodeSelectorTerms;

        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs> NodeSelectorTerms
        {
            get => _nodeSelectorTerms ?? (_nodeSelectorTerms = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>());
            set => _nodeSelectorTerms = value;
        }

        public ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs()
        {
        }
        public static new ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs Empty => new ClusterSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs();
    }
}