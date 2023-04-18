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
    /// The configuration for the CA and related certificates
    /// </summary>
    public class ClusterSpecCertificatesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The secret containing the Client CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate all the client certificates.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the client certificates, used as `ssl_ca_file` of all the instances.&lt;br /&gt; - `ca.key`: key used to generate client certificates, if ReplicationTLSSecret is provided, this can be omitted.&lt;br /&gt;
        /// </summary>
        [Input("clientCASecret")]
        public Input<string>? ClientCASecret { get; set; }

        /// <summary>
        /// The secret of type kubernetes.io/tls containing the client certificate to authenticate as the `streaming_replica` user. If not defined, ClientCASecret must provide also `ca.key`, and a new secret will be created using the provided CA.
        /// </summary>
        [Input("replicationTLSSecret")]
        public Input<string>? ReplicationTLSSecret { get; set; }

        [Input("serverAltDNSNames")]
        private InputList<string>? _serverAltDNSNames;

        /// <summary>
        /// The list of the server alternative DNS names to be added to the generated server TLS certificates, when required.
        /// </summary>
        public InputList<string> ServerAltDNSNames
        {
            get => _serverAltDNSNames ?? (_serverAltDNSNames = new InputList<string>());
            set => _serverAltDNSNames = value;
        }

        /// <summary>
        /// The secret containing the Server CA certificate. If not defined, a new secret will be created with a self-signed CA and will be used to generate the TLS certificate ServerTLSSecret.&lt;br /&gt; &lt;br /&gt; Contains:&lt;br /&gt; &lt;br /&gt; - `ca.crt`: CA that should be used to validate the server certificate, used as `sslrootcert` in client connection strings.&lt;br /&gt; - `ca.key`: key used to generate Server SSL certs, if ServerTLSSecret is provided, this can be omitted.&lt;br /&gt;
        /// </summary>
        [Input("serverCASecret")]
        public Input<string>? ServerCASecret { get; set; }

        /// <summary>
        /// The secret of type kubernetes.io/tls containing the server TLS certificate and key that will be set as `ssl_cert_file` and `ssl_key_file` so that clients can connect to postgres securely. If not defined, ServerCASecret must provide also `ca.key` and a new secret will be created using the provided CA.
        /// </summary>
        [Input("serverTLSSecret")]
        public Input<string>? ServerTLSSecret { get; set; }

        public ClusterSpecCertificatesArgs()
        {
        }
        public static new ClusterSpecCertificatesArgs Empty => new ClusterSpecCertificatesArgs();
    }
}
