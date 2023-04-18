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
    /// Name of the secret containing the initial credentials for the owner of the user database. If empty a new secret will be created from scratch
    /// </summary>
    public class ClusterSpecBootstrapPg_basebackupSecretArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterSpecBootstrapPg_basebackupSecretArgs()
        {
        }
        public static new ClusterSpecBootstrapPg_basebackupSecretArgs Empty => new ClusterSpecBootstrapPg_basebackupSecretArgs();
    }
}