// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// MiddlewareTCPSpec defines the desired state of a MiddlewareTCP.
    /// </summary>
    public class MiddlewareTCPSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// InFlightConn defines the InFlightConn middleware configuration.
        /// </summary>
        [Input("inFlightConn")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareTCPSpecInflightconnArgs>? InFlightConn { get; set; }

        /// <summary>
        /// IPWhiteList defines the IPWhiteList middleware configuration.
        /// </summary>
        [Input("ipWhiteList")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareTCPSpecIpwhitelistArgs>? IpWhiteList { get; set; }

        public MiddlewareTCPSpecArgs()
        {
        }
        public static new MiddlewareTCPSpecArgs Empty => new MiddlewareTCPSpecArgs();
    }
}
