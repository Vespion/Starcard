// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// TLS configuration to use when scraping the endpoint.
    /// </summary>
    public class ProbeSpecTlsconfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Certificate authority used when verifying server certificates.
        /// </summary>
        [Input("ca")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTlsconfigCaArgs>? Ca { get; set; }

        /// <summary>
        /// Client certificate to present when doing client-authentication.
        /// </summary>
        [Input("cert")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTlsconfigCertArgs>? Cert { get; set; }

        /// <summary>
        /// Disable target certificate validation.
        /// </summary>
        [Input("insecureSkipVerify")]
        public Input<bool>? InsecureSkipVerify { get; set; }

        /// <summary>
        /// Secret containing the client key file for the targets.
        /// </summary>
        [Input("keySecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ProbeSpecTlsconfigKeysecretArgs>? KeySecret { get; set; }

        /// <summary>
        /// Used to verify the hostname for the targets.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public ProbeSpecTlsconfigArgs()
        {
        }
        public static new ProbeSpecTlsconfigArgs Empty => new ProbeSpecTlsconfigArgs();
    }
}