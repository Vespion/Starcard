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
    /// Password for user defined in HTTP_User
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecEsHttppassword
    {
        /// <summary>
        /// ValueSource defines how to find a value's key.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttppasswordValuefrom ValueFrom;

        [OutputConstructor]
        private ClusterOutputSpecEsHttppassword(Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsHttppasswordValuefrom valueFrom)
        {
            ValueFrom = valueFrom;
        }
    }
}
