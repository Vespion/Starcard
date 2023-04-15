// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// TLS configuration to use when scraping the endpoint.
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecTlsconfig
    {
        /// <summary>
        /// Certificate authority used when verifying server certificates.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCa Ca;
        /// <summary>
        /// Client certificate to present when doing client-authentication.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCert Cert;
        /// <summary>
        /// Disable target certificate validation.
        /// </summary>
        public readonly bool InsecureSkipVerify;
        /// <summary>
        /// Secret containing the client key file for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigKeysecret KeySecret;
        /// <summary>
        /// Used to verify the hostname for the targets.
        /// </summary>
        public readonly string ServerName;

        [OutputConstructor]
        private ProbeSpecTlsconfig(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCa ca,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigCert cert,

            bool insecureSkipVerify,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ProbeSpecTlsconfigKeysecret keySecret,

            string serverName)
        {
            Ca = ca;
            Cert = cert;
            InsecureSkipVerify = insecureSkipVerify;
            KeySecret = keySecret;
            ServerName = serverName;
        }
    }
}
