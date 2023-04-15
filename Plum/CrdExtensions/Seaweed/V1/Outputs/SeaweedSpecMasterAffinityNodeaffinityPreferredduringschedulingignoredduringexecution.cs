// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecMasterAffinityNodeaffinityPreferredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference Preference;
        /// <summary>
        /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private SeaweedSpecMasterAffinityNodeaffinityPreferredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}
