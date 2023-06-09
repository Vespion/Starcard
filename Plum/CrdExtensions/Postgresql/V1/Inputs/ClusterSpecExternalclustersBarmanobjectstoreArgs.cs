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
    /// The configuration for the barman-cloud tool suite
    /// </summary>
    public class ClusterSpecExternalclustersBarmanobjectstoreArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The credentials to use to upload data to Azure Blob Storage
        /// </summary>
        [Input("azureCredentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreAzurecredentialsArgs>? AzureCredentials { get; set; }

        /// <summary>
        /// The configuration to be used to backup the data files When not defined, base backups files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.
        /// </summary>
        [Input("data")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreDataArgs>? Data { get; set; }

        /// <summary>
        /// The path where to store the backup (i.e. s3://bucket/path/to/folder) this path, with different destination folders, will be used for WALs and for data
        /// </summary>
        [Input("destinationPath", required: true)]
        public Input<string> DestinationPath { get; set; } = null!;

        /// <summary>
        /// EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive
        /// </summary>
        [Input("endpointCA")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreEndpointcaArgs>? EndpointCA { get; set; }

        /// <summary>
        /// Endpoint to be used to upload data to the cloud, overriding the automatic endpoint discovery
        /// </summary>
        [Input("endpointURL")]
        public Input<string>? EndpointURL { get; set; }

        /// <summary>
        /// The credentials to use to upload data to Google Cloud Storage
        /// </summary>
        [Input("googleCredentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreGooglecredentialsArgs>? GoogleCredentials { get; set; }

        [Input("historyTags")]
        private InputMap<string>? _historyTags;

        /// <summary>
        /// HistoryTags is a list of key value pairs that will be passed to the Barman --history-tags option.
        /// </summary>
        public InputMap<string> HistoryTags
        {
            get => _historyTags ?? (_historyTags = new InputMap<string>());
            set => _historyTags = value;
        }

        /// <summary>
        /// The credentials to use to upload data to S3
        /// </summary>
        [Input("s3Credentials")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsArgs>? S3Credentials { get; set; }

        /// <summary>
        /// The server name on S3, the cluster name is used if this parameter is omitted
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags is a list of key value pairs that will be passed to the Barman --tags option.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The configuration for the backup of the WAL stream. When not defined, WAL files will be stored uncompressed and may be unencrypted in the object store, according to the bucket default policy.
        /// </summary>
        [Input("wal")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreWalArgs>? Wal { get; set; }

        public ClusterSpecExternalclustersBarmanobjectstoreArgs()
        {
        }
        public static new ClusterSpecExternalclustersBarmanobjectstoreArgs Empty => new ClusterSpecExternalclustersBarmanobjectstoreArgs();
    }
}
