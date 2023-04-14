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
    /// ProxyProtocol defines the PROXY protocol configuration. More info: https://doc.traefik.io/traefik/v2.9/routing/services/#proxy-protocol
    /// </summary>
    [OutputType]
    public sealed class IngressRouteTCPSpecRoutesServicesProxyprotocol
    {
        /// <summary>
        /// Version defines the PROXY Protocol version to use.
        /// </summary>
        public readonly int Version;

        [OutputConstructor]
        private IngressRouteTCPSpecRoutesServicesProxyprotocol(int version)
        {
            Version = version;
        }
    }
}
