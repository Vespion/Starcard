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
    /// Replication slots management configuration
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecReplicationslots
    {
        /// <summary>
        /// Replication slots for high availability configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecReplicationslotsHighavailability HighAvailability;
        /// <summary>
        /// Standby will update the status of the local replication slots every `updateInterval` seconds (default 30).
        /// </summary>
        public readonly int UpdateInterval;

        [OutputConstructor]
        private ClusterSpecReplicationslots(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecReplicationslotsHighavailability highAvailability,

            int updateInterval)
        {
            HighAvailability = highAvailability;
            UpdateInterval = updateInterval;
        }
    }
}
