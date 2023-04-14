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
    /// IPWhiteList holds the IP whitelist middleware configuration. This middleware accepts / refuses requests based on the client IP. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ipwhitelist/
    /// </summary>
    public class MiddlewareSpecIpwhitelistArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// IPStrategy holds the IP strategy configuration used by Traefik to determine the client IP. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ipwhitelist/#ipstrategy
        /// </summary>
        [Input("ipStrategy")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecIpwhitelistIpstrategyArgs>? IpStrategy { get; set; }

        [Input("sourceRange")]
        private InputList<string>? _sourceRange;

        /// <summary>
        /// SourceRange defines the set of allowed IPs (or ranges of allowed IPs by using CIDR notation).
        /// </summary>
        public InputList<string> SourceRange
        {
            get => _sourceRange ?? (_sourceRange = new InputList<string>());
            set => _sourceRange = value;
        }

        public MiddlewareSpecIpwhitelistArgs()
        {
        }
        public static new MiddlewareSpecIpwhitelistArgs Empty => new MiddlewareSpecIpwhitelistArgs();
    }
}
