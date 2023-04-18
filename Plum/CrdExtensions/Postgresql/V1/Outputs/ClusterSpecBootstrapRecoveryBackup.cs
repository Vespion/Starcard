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
    /// The backup we need to restore
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecBootstrapRecoveryBackup
    {
        /// <summary>
        /// EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecBootstrapRecoveryBackupEndpointca EndpointCA;
        /// <summary>
        /// Name of the referent.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ClusterSpecBootstrapRecoveryBackup(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.ClusterSpecBootstrapRecoveryBackupEndpointca endpointCA,

            string name)
        {
            EndpointCA = endpointCA;
            Name = name;
        }
    }
}
