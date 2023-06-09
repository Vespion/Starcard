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
    /// Instructions to bootstrap this cluster
    /// </summary>
    public class ClusterSpecBootstrapArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bootstrap the cluster via initdb
        /// </summary>
        [Input("initdb")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapInitdbArgs>? Initdb { get; set; }

        /// <summary>
        /// Bootstrap the cluster taking a physical backup of another compatible PostgreSQL instance
        /// </summary>
        [Input("pg_basebackup")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapPg_basebackupArgs>? Pg_basebackup { get; set; }

        /// <summary>
        /// Bootstrap the cluster from a backup
        /// </summary>
        [Input("recovery")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapRecoveryArgs>? Recovery { get; set; }

        public ClusterSpecBootstrapArgs()
        {
        }
        public static new ClusterSpecBootstrapArgs Empty => new ClusterSpecBootstrapArgs();
    }
}
