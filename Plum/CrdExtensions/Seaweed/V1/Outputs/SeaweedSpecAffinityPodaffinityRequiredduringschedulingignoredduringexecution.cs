// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// A label query over a set of resources, in this case pods.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector LabelSelector;
        /// <summary>
        /// namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
        /// </summary>
        public readonly ImmutableArray<string> Namespaces;
        /// <summary>
        /// This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
        /// </summary>
        public readonly string TopologyKey;

        [OutputConstructor]
        private SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecAffinityPodaffinityRequiredduringschedulingignoredduringexecutionLabelselector labelSelector,

            ImmutableArray<string> namespaces,

            string topologyKey)
        {
            LabelSelector = labelSelector;
            Namespaces = namespaces;
            TopologyKey = topologyKey;
        }
    }
}
