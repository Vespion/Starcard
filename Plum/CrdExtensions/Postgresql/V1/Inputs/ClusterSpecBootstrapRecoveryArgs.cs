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
    /// Bootstrap the cluster from a backup
    /// </summary>
    public class ClusterSpecBootstrapRecoveryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The backup we need to restore
        /// </summary>
        [Input("backup")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapRecoveryBackupArgs>? Backup { get; set; }

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
        /// By default, the recovery process applies all the available WAL files in the archive (full recovery). However, you can also end the recovery as soon as a consistent state is reached or recover to a point-in-time (PITR) by specifying a `RecoveryTarget` object, as expected by PostgreSQL (i.e., timestamp, transaction Id, LSN, ...). More info: https://www.postgresql.org/docs/current/runtime-config-wal.html#RUNTIME-CONFIG-WAL-RECOVERY-TARGET
        /// </summary>
        [Input("recoveryTarget")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapRecoveryRecoverytargetArgs>? RecoveryTarget { get; set; }

        /// <summary>
        /// Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecBootstrapRecoverySecretArgs>? Secret { get; set; }

        /// <summary>
        /// The external cluster whose backup we will restore. This is also used as the name of the folder under which the backup is stored, so it must be set to the name of the source cluster
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        public ClusterSpecBootstrapRecoveryArgs()
        {
        }
        public static new ClusterSpecBootstrapRecoveryArgs Empty => new ClusterSpecBootstrapRecoveryArgs();
    }
}
