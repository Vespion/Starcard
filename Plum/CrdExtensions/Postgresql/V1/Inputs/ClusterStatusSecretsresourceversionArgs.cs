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
    /// The list of resource versions of the secrets managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the secret data
    /// </summary>
    public class ClusterStatusSecretsresourceversionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource version of the "app" user secret
        /// </summary>
        [Input("applicationSecretVersion")]
        public Input<string>? ApplicationSecretVersion { get; set; }

        /// <summary>
        /// The resource version of the Barman Endpoint CA if provided
        /// </summary>
        [Input("barmanEndpointCA")]
        public Input<string>? BarmanEndpointCA { get; set; }

        /// <summary>
        /// Unused. Retained for compatibility with old versions.
        /// </summary>
        [Input("caSecretVersion")]
        public Input<string>? CaSecretVersion { get; set; }

        /// <summary>
        /// The resource version of the PostgreSQL client-side CA secret version
        /// </summary>
        [Input("clientCaSecretVersion")]
        public Input<string>? ClientCaSecretVersion { get; set; }

        [Input("metrics")]
        private InputMap<string>? _metrics;

        /// <summary>
        /// A map with the versions of all the secrets used to pass metrics. Map keys are the secret names, map values are the versions
        /// </summary>
        public InputMap<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputMap<string>());
            set => _metrics = value;
        }

        /// <summary>
        /// The resource version of the "streaming_replica" user secret
        /// </summary>
        [Input("replicationSecretVersion")]
        public Input<string>? ReplicationSecretVersion { get; set; }

        /// <summary>
        /// The resource version of the PostgreSQL server-side CA secret version
        /// </summary>
        [Input("serverCaSecretVersion")]
        public Input<string>? ServerCaSecretVersion { get; set; }

        /// <summary>
        /// The resource version of the PostgreSQL server-side secret version
        /// </summary>
        [Input("serverSecretVersion")]
        public Input<string>? ServerSecretVersion { get; set; }

        /// <summary>
        /// The resource version of the "postgres" user secret
        /// </summary>
        [Input("superuserSecretVersion")]
        public Input<string>? SuperuserSecretVersion { get; set; }

        public ClusterStatusSecretsresourceversionArgs()
        {
        }
        public static new ClusterStatusSecretsresourceversionArgs Empty => new ClusterStatusSecretsresourceversionArgs();
    }
}
