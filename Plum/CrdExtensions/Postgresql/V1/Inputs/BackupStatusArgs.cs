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
    /// Most recently observed status of the backup. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    public class BackupStatusArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The credentials to use to upload data to Azure Blob Storage
        /// </summary>
        [Input("azureCredentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusAzurecredentialsArgs>? AzureCredentials { get; set; }

        /// <summary>
        /// The ID of the Barman backup
        /// </summary>
        [Input("backupId")]
        public Input<string>? BackupId { get; set; }

        /// <summary>
        /// The Name of the Barman backup
        /// </summary>
        [Input("backupName")]
        public Input<string>? BackupName { get; set; }

        /// <summary>
        /// The starting xlog
        /// </summary>
        [Input("beginLSN")]
        public Input<string>? BeginLSN { get; set; }

        /// <summary>
        /// The starting WAL
        /// </summary>
        [Input("beginWal")]
        public Input<string>? BeginWal { get; set; }

        /// <summary>
        /// The backup command output in case of error
        /// </summary>
        [Input("commandError")]
        public Input<string>? CommandError { get; set; }

        /// <summary>
        /// Unused. Retained for compatibility with old versions.
        /// </summary>
        [Input("commandOutput")]
        public Input<string>? CommandOutput { get; set; }

        /// <summary>
        /// The path where to store the backup (i.e. s3://bucket/path/to/folder) this path, with different destination folders, will be used for WALs and for data. This may not be populated in case of errors.
        /// </summary>
        [Input("destinationPath")]
        public Input<string>? DestinationPath { get; set; }

        /// <summary>
        /// Encryption method required to S3 API
        /// </summary>
        [Input("encryption")]
        public Input<string>? Encryption { get; set; }

        /// <summary>
        /// The ending xlog
        /// </summary>
        [Input("endLSN")]
        public Input<string>? EndLSN { get; set; }

        /// <summary>
        /// The ending WAL
        /// </summary>
        [Input("endWal")]
        public Input<string>? EndWal { get; set; }

        /// <summary>
        /// EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.
        /// </summary>
        [Input("endpointCA")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusEndpointcaArgs>? EndpointCA { get; set; }

        /// <summary>
        /// Endpoint to be used to upload data to the cloud, overriding the automatic endpoint discovery
        /// </summary>
        [Input("endpointURL")]
        public Input<string>? EndpointURL { get; set; }

        /// <summary>
        /// The detected error
        /// </summary>
        [Input("error")]
        public Input<string>? Error { get; set; }

        /// <summary>
        /// The credentials to use to upload data to Google Cloud Storage
        /// </summary>
        [Input("googleCredentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusGooglecredentialsArgs>? GoogleCredentials { get; set; }

        /// <summary>
        /// Information to identify the instance where the backup has been taken from
        /// </summary>
        [Input("instanceID")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusInstanceidArgs>? InstanceID { get; set; }

        /// <summary>
        /// The last backup status
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        /// <summary>
        /// The credentials to use to upload data to S3
        /// </summary>
        [Input("s3Credentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusS3credentialsArgs>? S3Credentials { get; set; }

        /// <summary>
        /// The server name on S3, the cluster name is used if this parameter is omitted
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// When the backup was started
        /// </summary>
        [Input("startedAt")]
        public Input<string>? StartedAt { get; set; }

        /// <summary>
        /// When the backup was terminated
        /// </summary>
        [Input("stoppedAt")]
        public Input<string>? StoppedAt { get; set; }

        public BackupStatusArgs()
        {
        }
        public static new BackupStatusArgs Empty => new BackupStatusArgs();
    }
}