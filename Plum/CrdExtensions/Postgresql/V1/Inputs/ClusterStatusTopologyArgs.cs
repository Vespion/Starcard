// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Postgresql.V1
{

    /// <summary>
    /// Instances topology.
    /// </summary>
    public class ClusterStatusTopologyArgs : global::Pulumi.ResourceArgs
    {
        [Input("instances")]
        private InputMap<ImmutableDictionary<string, string>>? _instances;

        /// <summary>
        /// Instances contains the pod topology of the instances
        /// </summary>
        public InputMap<ImmutableDictionary<string, string>> Instances
        {
            get => _instances ?? (_instances = new InputMap<ImmutableDictionary<string, string>>());
            set => _instances = value;
        }

        /// <summary>
        /// SuccessfullyExtracted indicates if the topology data was extract. It is useful to enact fallback behaviors in synchronous replica election in case of failures
        /// </summary>
        [Input("successfullyExtracted")]
        public Input<bool>? SuccessfullyExtracted { get; set; }

        public ClusterStatusTopologyArgs()
        {
        }
        public static new ClusterStatusTopologyArgs Empty => new ClusterStatusTopologyArgs();
    }
}