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
    /// Configure the generation of the service account
    /// </summary>
    public class ClusterSpecServiceaccounttemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Metadata are the metadata to be used for the generated service account
        /// </summary>
        [Input("metadata", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.ClusterSpecServiceaccounttemplateMetadataArgs> Metadata { get; set; } = null!;

        public ClusterSpecServiceaccounttemplateArgs()
        {
        }
        public static new ClusterSpecServiceaccounttemplateArgs Empty => new ClusterSpecServiceaccounttemplateArgs();
    }
}
