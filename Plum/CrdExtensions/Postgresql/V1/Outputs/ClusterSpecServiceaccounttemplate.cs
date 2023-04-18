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
    /// Configure the generation of the service account
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecServiceaccounttemplate
    {
        /// <summary>
        /// Metadata are the metadata to be used for the generated service account
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecServiceaccounttemplateMetadata Metadata;

        [OutputConstructor]
        private ClusterSpecServiceaccounttemplate(Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecServiceaccounttemplateMetadata metadata)
        {
            Metadata = metadata;
        }
    }
}