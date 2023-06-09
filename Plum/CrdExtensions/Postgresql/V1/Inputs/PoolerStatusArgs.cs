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
    /// PoolerStatus defines the observed state of Pooler
    /// </summary>
    public class PoolerStatusArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of pods trying to be scheduled
        /// </summary>
        [Input("instances")]
        public Input<int>? Instances { get; set; }

        /// <summary>
        /// The resource version of the config object
        /// </summary>
        [Input("secrets")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerStatusSecretsArgs>? Secrets { get; set; }

        public PoolerStatusArgs()
        {
        }
        public static new PoolerStatusArgs Empty => new PoolerStatusArgs();
    }
}
