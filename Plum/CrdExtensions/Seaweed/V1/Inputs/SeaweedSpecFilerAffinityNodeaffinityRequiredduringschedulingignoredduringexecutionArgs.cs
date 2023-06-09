// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
    /// </summary>
    public class SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs : global::Pulumi.ResourceArgs
    {
        [Input("nodeSelectorTerms", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>? _nodeSelectorTerms;

        /// <summary>
        /// Required. A list of node selector terms. The terms are ORed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs> NodeSelectorTerms
        {
            get => _nodeSelectorTerms ?? (_nodeSelectorTerms = new InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs>());
            set => _nodeSelectorTerms = value;
        }

        public SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs()
        {
        }
        public static new SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs Empty => new SeaweedSpecFilerAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionArgs();
    }
}
