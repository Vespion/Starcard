// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// A node selector term, associated with the corresponding weight.
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference
    {
        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressions> MatchExpressions;
        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfields> MatchFields;

        [OutputConstructor]
        private SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchexpressions> matchExpressions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecVolumeAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreferenceMatchfields> matchFields)
        {
            MatchExpressions = matchExpressions;
            MatchFields = matchFields;
        }
    }
}
