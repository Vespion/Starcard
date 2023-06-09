// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// TLS configuration to use when scraping the endpoint
    /// </summary>
    public class ServiceMonitorSpecEndpointsTlsconfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Certificate authority used when verifying server certificates.
        /// </summary>
        [Input("ca")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsconfigCaArgs>? Ca { get; set; }

        /// <summary>
        /// Path to the CA cert in the Prometheus container to use for the targets.
        /// </summary>
        [Input("caFile")]
        public Input<string>? CaFile { get; set; }

        /// <summary>
        /// Client certificate to present when doing client-authentication.
        /// </summary>
        [Input("cert")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsconfigCertArgs>? Cert { get; set; }

        /// <summary>
        /// Path to the client cert file in the Prometheus container for the targets.
        /// </summary>
        [Input("certFile")]
        public Input<string>? CertFile { get; set; }

        /// <summary>
        /// Disable target certificate validation.
        /// </summary>
        [Input("insecureSkipVerify")]
        public Input<bool>? InsecureSkipVerify { get; set; }

        /// <summary>
        /// Path to the client key file in the Prometheus container for the targets.
        /// </summary>
        [Input("keyFile")]
        public Input<string>? KeyFile { get; set; }

        /// <summary>
        /// Secret containing the client key file for the targets.
        /// </summary>
        [Input("keySecret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsTlsconfigKeysecretArgs>? KeySecret { get; set; }

        /// <summary>
        /// Used to verify the hostname for the targets.
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        public ServiceMonitorSpecEndpointsTlsconfigArgs()
        {
        }
        public static new ServiceMonitorSpecEndpointsTlsconfigArgs Empty => new ServiceMonitorSpecEndpointsTlsconfigArgs();
    }
}
