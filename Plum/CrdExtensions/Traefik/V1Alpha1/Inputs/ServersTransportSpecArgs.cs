// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// ServersTransportSpec defines the desired state of a ServersTransport.
    /// </summary>
    public class ServersTransportSpecArgs : global::Pulumi.ResourceArgs
    {
        [Input("certificatesSecrets")]
        private InputList<string>? _certificatesSecrets;

        /// <summary>
        /// CertificatesSecrets defines a list of secret storing client certificates for mTLS.
        /// </summary>
        public InputList<string> CertificatesSecrets
        {
            get => _certificatesSecrets ?? (_certificatesSecrets = new InputList<string>());
            set => _certificatesSecrets = value;
        }

        /// <summary>
        /// DisableHTTP2 disables HTTP/2 for connections with backend servers.
        /// </summary>
        [Input("disableHTTP2")]
        public Input<bool>? DisableHTTP2 { get; set; }

        /// <summary>
        /// ForwardingTimeouts defines the timeouts for requests forwarded to the backend servers.
        /// </summary>
        [Input("forwardingTimeouts")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.ServersTransportSpecForwardingtimeoutsArgs>? ForwardingTimeouts { get; set; }

        /// <summary>
        /// InsecureSkipVerify disables SSL certificate verification.
        /// </summary>
        [Input("insecureSkipVerify")]
        public Input<bool>? InsecureSkipVerify { get; set; }

        /// <summary>
        /// MaxIdleConnsPerHost controls the maximum idle (keep-alive) to keep per-host.
        /// </summary>
        [Input("maxIdleConnsPerHost")]
        public Input<int>? MaxIdleConnsPerHost { get; set; }

        /// <summary>
        /// PeerCertURI defines the peer cert URI used to match against SAN URI during the peer certificate verification.
        /// </summary>
        [Input("peerCertURI")]
        public Input<string>? PeerCertURI { get; set; }

        [Input("rootCAsSecrets")]
        private InputList<string>? _rootCAsSecrets;

        /// <summary>
        /// RootCAsSecrets defines a list of CA secret used to validate self-signed certificate.
        /// </summary>
        public InputList<string> RootCAsSecrets
        {
            get => _rootCAsSecrets ?? (_rootCAsSecrets = new InputList<string>());
            set => _rootCAsSecrets = value;
        }

        /// <summary>
        /// ServerName defines the server name used to contact the server.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public ServersTransportSpecArgs()
        {
        }
        public static new ServersTransportSpecArgs Empty => new ServersTransportSpecArgs();
    }
}