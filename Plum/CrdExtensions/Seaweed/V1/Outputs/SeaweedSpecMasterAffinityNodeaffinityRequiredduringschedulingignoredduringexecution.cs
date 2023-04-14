// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecMasterAffinityNodeaffinityRequiredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectorterms> NodeSelectorTerms;

        [OutputConstructor]
        private SeaweedSpecMasterAffinityNodeaffinityRequiredduringschedulingignoredduringexecution(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectorterms> nodeSelectorTerms)
        {
            NodeSelectorTerms = nodeSelectorTerms;
        }
    }
}
