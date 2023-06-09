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
    /// Bootstrap the cluster taking a physical backup of another compatible PostgreSQL instance
    /// </summary>
    public class ClusterSpecBootstrapPg_basebackupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the database used by the application. Default: `app`.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// Name of the owner of the database in the instance to be used by applications. Defaults to the value of the `database` key.
        /// </summary>
        [Input("owner")]
        public Input<string>? Owner { get; set; }

        /// <summary>
        /// Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapPg_basebackupSecretArgs>? Secret { get; set; }

        /// <summary>
        /// The name of the server of which we need to take a physical backup
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        public ClusterSpecBootstrapPg_basebackupArgs()
        {
        }
        public static new ClusterSpecBootstrapPg_basebackupArgs Empty => new ClusterSpecBootstrapPg_basebackupArgs();
    }
}
