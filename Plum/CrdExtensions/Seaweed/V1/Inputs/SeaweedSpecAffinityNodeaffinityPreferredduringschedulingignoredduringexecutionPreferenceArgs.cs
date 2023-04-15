// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    public class SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs>? _matchExpressions;

        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs>? _matchFields;

        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs>());
            set => _matchFields = value;
        }

        public SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs()
        {
        }
        public static new SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs Empty => new SeaweedSpecAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs();
    }
}
