// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecAffinityPodaffinityPreferredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// Required. A pod affinity term, associated with the corresponding weight.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionPodaffinityterm PodAffinityTerm;
        /// <summary>
        /// weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private PoolerSpecTemplateSpecAffinityPodaffinityPreferredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityPodaffinityPreferredduringschedulingignoredduringexecutionPodaffinityterm podAffinityTerm,

            int weight)
        {
            PodAffinityTerm = podAffinityTerm;
            Weight = weight;
        }
    }
}
