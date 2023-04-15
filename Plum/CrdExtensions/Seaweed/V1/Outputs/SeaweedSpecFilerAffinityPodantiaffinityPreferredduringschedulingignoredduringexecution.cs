// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecFilerAffinityPodantiaffinityPreferredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// Required. A pod affinity term, associated with the corresponding weight.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecFilerAffinityPodantiaffinityPreferredduringschedulingignoredduringexecutionPodaffinityterm PodAffinityTerm;
        /// <summary>
        /// weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private SeaweedSpecFilerAffinityPodantiaffinityPreferredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecFilerAffinityPodantiaffinityPreferredduringschedulingignoredduringexecutionPodaffinityterm podAffinityTerm,

            int weight)
        {
            PodAffinityTerm = podAffinityTerm;
            Weight = weight;
        }
    }
}
