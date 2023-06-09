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
    /// The credentials to use to upload data to S3
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecExternalclustersBarmanobjectstoreS3credentials
    {
        /// <summary>
        /// The reference to the access key id
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsAccesskeyid AccessKeyId;
        /// <summary>
        /// Use the role based authentication without providing explicitly the keys.
        /// </summary>
        public readonly bool InheritFromIAMRole;
        /// <summary>
        /// The reference to the secret containing the region name
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsRegion Region;
        /// <summary>
        /// The reference to the secret access key
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsSecretaccesskey SecretAccessKey;
        /// <summary>
        /// The references to the session key
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsSessiontoken SessionToken;

        [OutputConstructor]
        private ClusterSpecExternalclustersBarmanobjectstoreS3credentials(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsAccesskeyid accessKeyId,

            bool inheritFromIAMRole,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsRegion region,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsSecretaccesskey secretAccessKey,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecExternalclustersBarmanobjectstoreS3credentialsSessiontoken sessionToken)
        {
            AccessKeyId = accessKeyId;
            InheritFromIAMRole = inheritFromIAMRole;
            Region = region;
            SecretAccessKey = secretAccessKey;
            SessionToken = sessionToken;
        }
    }
}
