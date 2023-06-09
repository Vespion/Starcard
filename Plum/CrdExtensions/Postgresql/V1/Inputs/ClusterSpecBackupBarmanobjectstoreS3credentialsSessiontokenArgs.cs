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
    /// The references to the session key
    /// </summary>
    public class ClusterSpecBackupBarmanobjectstoreS3credentialsSessiontokenArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key to select
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Name of the referent.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterSpecBackupBarmanobjectstoreS3credentialsSessiontokenArgs()
        {
        }
        public static new ClusterSpecBackupBarmanobjectstoreS3credentialsSessiontokenArgs Empty => new ClusterSpecBackupBarmanobjectstoreS3credentialsSessiontokenArgs();
    }
}
