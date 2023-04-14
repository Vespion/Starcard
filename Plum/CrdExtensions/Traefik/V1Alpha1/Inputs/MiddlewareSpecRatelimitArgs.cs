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
    /// RateLimit holds the rate limit configuration. This middleware ensures that services will receive a fair amount of requests, and allows one to define what fair is. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/ratelimit/
    /// </summary>
    public class MiddlewareSpecRatelimitArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Average is the maximum rate, by default in requests/s, allowed for the given source. It defaults to 0, which means no rate limiting. The rate is actually defined by dividing Average by Period. So for a rate below 1req/s, one needs to define a Period larger than a second.
        /// </summary>
        [Input("average")]
        public Input<int>? Average { get; set; }

        /// <summary>
        /// Burst is the maximum number of requests allowed to arrive in the same arbitrarily small period of time. It defaults to 1.
        /// </summary>
        [Input("burst")]
        public Input<int>? Burst { get; set; }

        /// <summary>
        /// Period, in combination with Average, defines the actual maximum rate, such as: r = Average / Period. It defaults to a second.
        /// </summary>
        [Input("period")]
        public InputUnion<int, string>? Period { get; set; }

        /// <summary>
        /// SourceCriterion defines what criterion is used to group requests as originating from a common source. If several strategies are defined at the same time, an error will be raised. If none are set, the default is to use the request's remote address field (as an ipStrategy).
        /// </summary>
        [Input("sourceCriterion")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecRatelimitSourcecriterionArgs>? SourceCriterion { get; set; }

        public MiddlewareSpecRatelimitArgs()
        {
        }
        public static new MiddlewareSpecRatelimitArgs Empty => new MiddlewareSpecRatelimitArgs();
    }
}
