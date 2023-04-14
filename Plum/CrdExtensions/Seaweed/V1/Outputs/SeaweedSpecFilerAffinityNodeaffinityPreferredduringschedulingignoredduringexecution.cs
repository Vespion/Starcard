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
    /// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecution
    {
        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference Preference;
        /// <summary>
        /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecution(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecFilerAffinityNodeaffinityPreferredduringschedulingignoredduringexecutionPreference preference,

            int weight)
        {
            Preference = preference;
            Weight = weight;
        }
    }
}
