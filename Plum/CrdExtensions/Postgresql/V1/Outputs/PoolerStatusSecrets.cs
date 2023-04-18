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
    /// The resource version of the config object
    /// </summary>
    [OutputType]
    public sealed class PoolerStatusSecrets
    {
        /// <summary>
        /// The client CA secret version
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsClientca ClientCA;
        /// <summary>
        /// The version of the secrets used by PgBouncer
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsPgbouncersecrets PgBouncerSecrets;
        /// <summary>
        /// The server CA secret version
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsServerca ServerCA;
        /// <summary>
        /// The server TLS secret version
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsServertls ServerTLS;

        [OutputConstructor]
        private PoolerStatusSecrets(
            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsClientca clientCA,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsPgbouncersecrets pgBouncerSecrets,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsServerca serverCA,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerStatusSecretsServertls serverTLS)
        {
            ClientCA = clientCA;
            PgBouncerSecrets = pgBouncerSecrets;
            ServerCA = serverCA;
            ServerTLS = serverTLS;
        }
    }
}
