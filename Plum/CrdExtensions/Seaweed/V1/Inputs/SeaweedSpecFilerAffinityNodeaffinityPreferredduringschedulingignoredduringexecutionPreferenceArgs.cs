// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    public class SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs>? _matchExpressions;

        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs>? _matchFields;

        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfieldsArgs>());
            set => _matchFields = value;
        }

        public SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs()
        {
        }
        public static new SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs Empty => new SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceArgs();
    }
}
