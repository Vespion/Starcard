// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// ForwardingTimeouts defines the timeouts for requests forwarded to the backend servers.
    /// </summary>
    [OutputType]
    public sealed class ServersTransportSpecForwardingtimeouts
    {
        /// <summary>
        /// DialTimeout is the amount of time to wait until a connection to a backend server can be established.
        /// </summary>
        public readonly Union<int, string> DialTimeout;
        /// <summary>
        /// IdleConnTimeout is the maximum period for which an idle HTTP keep-alive connection will remain open before closing itself.
        /// </summary>
        public readonly Union<int, string> IdleConnTimeout;
        /// <summary>
        /// PingTimeout is the timeout after which the HTTP/2 connection will be closed if a response to ping is not received.
        /// </summary>
        public readonly Union<int, string> PingTimeout;
        /// <summary>
        /// ReadIdleTimeout is the timeout after which a health check using ping frame will be carried out if no frame is received on the HTTP/2 connection.
        /// </summary>
        public readonly Union<int, string> ReadIdleTimeout;
        /// <summary>
        /// ResponseHeaderTimeout is the amount of time to wait for a server's response headers after fully writing the request (including its body, if any).
        /// </summary>
        public readonly Union<int, string> ResponseHeaderTimeout;

        [OutputConstructor]
        private ServersTransportSpecForwardingtimeouts(
            Union<int, string> dialTimeout,

            Union<int, string> idleConnTimeout,

            Union<int, string> pingTimeout,

            Union<int, string> readIdleTimeout,

            Union<int, string> responseHeaderTimeout)
        {
            DialTimeout = dialTimeout;
            IdleConnTimeout = idleConnTimeout;
            PingTimeout = pingTimeout;
            ReadIdleTimeout = readIdleTimeout;
            ResponseHeaderTimeout = responseHeaderTimeout;
        }
    }
}