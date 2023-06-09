// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// InFlightConn defines the InFlightConn middleware configuration.
    /// </summary>
    [OutputType]
    public sealed class MiddlewareTCPSpecInflightconn
    {
        /// <summary>
        /// Amount defines the maximum amount of allowed simultaneous connections. The middleware closes the connection if there are already amount connections opened.
        /// </summary>
        public readonly int Amount;

        [OutputConstructor]
        private MiddlewareTCPSpecInflightconn(int amount)
        {
            Amount = amount;
        }
    }
}
