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
    /// PoolerSpec defines the desired state of Pooler
    /// </summary>
    public class PoolerSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This is the cluster reference on which the Pooler will work. Pooler name should never match with any cluster name within the same namespace.
        /// </summary>
        [Input("cluster", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecClusterArgs> Cluster { get; set; } = null!;

        /// <summary>
        /// The number of replicas we want
        /// </summary>
        [Input("instances", required: true)]
        public Input<int> Instances { get; set; } = null!;

        /// <summary>
        /// The PgBouncer configuration
        /// </summary>
        [Input("pgbouncer", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecPgbouncerArgs> Pgbouncer { get; set; } = null!;

        /// <summary>
        /// The template of the Pod to be created
        /// </summary>
        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateArgs>? Template { get; set; }

        /// <summary>
        /// Which instances we must forward traffic to?
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public PoolerSpecArgs()
        {
            Instances = 1;
            Type = "rw";
        }
        public static new PoolerSpecArgs Empty => new PoolerSpecArgs();
    }
}
