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
    /// A label query over a set of resources, in this case pods.
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector
    {
        /// <summary>
        /// matchExpressions is a list of label selector requirements. The requirements are ANDed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressions> MatchExpressions;
        /// <summary>
        /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        /// </summary>
        public readonly ImmutableDictionary<string, string> MatchLabels;

        [OutputConstructor]
        private SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselectorMatchexpressions> matchExpressions,

            ImmutableDictionary<string, string> matchLabels)
        {
            MatchExpressions = matchExpressions;
            MatchLabels = matchLabels;
        }
    }
}
