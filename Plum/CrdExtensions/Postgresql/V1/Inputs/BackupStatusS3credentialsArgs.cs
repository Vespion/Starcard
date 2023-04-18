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
    /// The credentials to use to upload data to S3
    /// </summary>
    public class BackupStatusS3credentialsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The reference to the access key id
        /// </summary>
        [Input("accessKeyId")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusS3credentialsAccesskeyidArgs>? AccessKeyId { get; set; }

        /// <summary>
        /// Use the role based authentication without providing explicitly the keys.
        /// </summary>
        [Input("inheritFromIAMRole")]
        public Input<bool>? InheritFromIAMRole { get; set; }

        /// <summary>
        /// The reference to the secret containing the region name
        /// </summary>
        [Input("region")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusS3credentialsRegionArgs>? Region { get; set; }

        /// <summary>
        /// The reference to the secret access key
        /// </summary>
        [Input("secretAccessKey")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusS3credentialsSecretaccesskeyArgs>? SecretAccessKey { get; set; }

        /// <summary>
        /// The references to the session key
        /// </summary>
        [Input("sessionToken")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.BackupStatusS3credentialsSessiontokenArgs>? SessionToken { get; set; }

        public BackupStatusS3credentialsArgs()
        {
        }
        public static new BackupStatusS3credentialsArgs Empty => new BackupStatusS3credentialsArgs();
    }
}