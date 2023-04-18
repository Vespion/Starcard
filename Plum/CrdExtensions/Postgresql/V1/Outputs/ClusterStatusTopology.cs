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
    /// Instances topology.
    /// </summary>
    [OutputType]
    public sealed class ClusterStatusTopology
    {
        /// <summary>
        /// Instances contains the pod topology of the instances
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableDictionary<string, string>> Instances;
        /// <summary>
        /// SuccessfullyExtracted indicates if the topology data was extract. It is useful to enact fallback behaviors in synchronous replica election in case of failures
        /// </summary>
        public readonly bool SuccessfullyExtracted;

        [OutputConstructor]
        private ClusterStatusTopology(
            ImmutableDictionary<string, ImmutableDictionary<string, string>> instances,

            bool successfullyExtracted)
        {
            Instances = instances;
            SuccessfullyExtracted = successfullyExtracted;
        }
    }
}