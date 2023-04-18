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
    /// The template of the Pod to be created
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplate
    {
        /// <summary>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateMetadata Metadata;
        /// <summary>
        /// Specification of the desired behavior of the pod. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpec Spec;

        [OutputConstructor]
        private PoolerSpecTemplate(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateMetadata metadata,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpec spec)
        {
            Metadata = metadata;
            Spec = spec;
        }
    }
}