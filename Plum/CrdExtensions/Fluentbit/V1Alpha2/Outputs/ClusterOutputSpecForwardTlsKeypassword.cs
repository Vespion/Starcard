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
    /// Optional password for tls.key_file file
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecForwardTlsKeypassword
    {
        /// <summary>
        /// ValueSource defines how to find a value's key.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecForwardTlsKeypasswordValuefrom ValueFrom;

        [OutputConstructor]
        private ClusterOutputSpecForwardTlsKeypassword(Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecForwardTlsKeypasswordValuefrom valueFrom)
        {
            ValueFrom = valueFrom;
        }
    }
}
