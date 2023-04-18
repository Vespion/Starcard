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
    /// The list of resource versions of the secrets managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the secret data
    /// </summary>
    [OutputType]
    public sealed class ClusterStatusSecretsresourceversion
    {
        /// <summary>
        /// The resource version of the "app" user secret
        /// </summary>
        public readonly string ApplicationSecretVersion;
        /// <summary>
        /// The resource version of the Barman Endpoint CA if provided
        /// </summary>
        public readonly string BarmanEndpointCA;
        /// <summary>
        /// Unused. Retained for compatibility with old versions.
        /// </summary>
        public readonly string CaSecretVersion;
        /// <summary>
        /// The resource version of the PostgreSQL client-side CA secret version
        /// </summary>
        public readonly string ClientCaSecretVersion;
        /// <summary>
        /// A map with the versions of all the secrets used to pass metrics. Map keys are the secret names, map values are the versions
        /// </summary>
        public readonly ImmutableDictionary<string, string> Metrics;
        /// <summary>
        /// The resource version of the "streaming_replica" user secret
        /// </summary>
        public readonly string ReplicationSecretVersion;
        /// <summary>
        /// The resource version of the PostgreSQL server-side CA secret version
        /// </summary>
        public readonly string ServerCaSecretVersion;
        /// <summary>
        /// The resource version of the PostgreSQL server-side secret version
        /// </summary>
        public readonly string ServerSecretVersion;
        /// <summary>
        /// The resource version of the "postgres" user secret
        /// </summary>
        public readonly string SuperuserSecretVersion;

        [OutputConstructor]
        private ClusterStatusSecretsresourceversion(
            string applicationSecretVersion,

            string barmanEndpointCA,

            string caSecretVersion,

            string clientCaSecretVersion,

            ImmutableDictionary<string, string> metrics,

            string replicationSecretVersion,

            string serverCaSecretVersion,

            string serverSecretVersion,

            string superuserSecretVersion)
        {
            ApplicationSecretVersion = applicationSecretVersion;
            BarmanEndpointCA = barmanEndpointCA;
            CaSecretVersion = caSecretVersion;
            ClientCaSecretVersion = clientCaSecretVersion;
            Metrics = metrics;
            ReplicationSecretVersion = replicationSecretVersion;
            ServerCaSecretVersion = serverCaSecretVersion;
            ServerSecretVersion = serverSecretVersion;
            SuperuserSecretVersion = superuserSecretVersion;
        }
    }
}