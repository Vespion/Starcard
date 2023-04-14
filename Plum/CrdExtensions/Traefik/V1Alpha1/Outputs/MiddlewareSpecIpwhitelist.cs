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
    /// IPWhiteList holds the IP whitelist middleware configuration. This middleware accepts / refuses requests based on the client IP. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ipwhitelist/
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecIpwhitelist
    {
        /// <summary>
        /// IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ipwhitelist/#ipstrategy
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecIpwhitelistIpstrategy IpStrategy;
        /// <summary>
        /// SourceRange defines the set of allowed IPs (or ranges of allowed IPs by using CIDR notation).
        /// </summary>
        public readonly ImmutableArray<string> SourceRange;

        [OutputConstructor]
        private MiddlewareSpecIpwhitelist(
            Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpecIpwhitelistIpstrategy ipStrategy,

            ImmutableArray<string> sourceRange)
        {
            IpStrategy = ipStrategy;
            SourceRange = sourceRange;
        }
    }
}
