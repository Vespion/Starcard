// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Optional username credential for access
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecOpensearchHttpuser
    {
        /// <summary>
        /// ValueSource defines how to find a value's key.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecOpensearchHttpuserValuefrom ValueFrom;

        [OutputConstructor]
        private ClusterOutputSpecOpensearchHttpuser(Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecOpensearchHttpuserValuefrom valueFrom)
        {
            ValueFrom = valueFrom;
        }
    }
}
