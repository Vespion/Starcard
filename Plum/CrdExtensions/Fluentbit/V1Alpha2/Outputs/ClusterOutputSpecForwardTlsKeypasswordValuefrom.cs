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
    /// ValueSource defines how to find a value's key.
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecForwardTlsKeypasswordValuefrom
    {
        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecForwardTlsKeypasswordValuefromSecretkeyref SecretKeyRef;

        [OutputConstructor]
        private ClusterOutputSpecForwardTlsKeypasswordValuefrom(Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecForwardTlsKeypasswordValuefromSecretkeyref secretKeyRef)
        {
            SecretKeyRef = secretKeyRef;
        }
    }
}
