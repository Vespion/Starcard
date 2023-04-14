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
    /// InFlightConn defines the InFlightConn middleware configuration.
    /// </summary>
    public class MiddlewareTCPSpecInflightconnArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amount defines the maximum amount of allowed simultaneous connections. The middleware closes the connection if there are already amount connections opened.
        /// </summary>
        [Input("amount")]
        public Input<int>? Amount { get; set; }

        public MiddlewareTCPSpecInflightconnArgs()
        {
        }
        public static new MiddlewareTCPSpecInflightconnArgs Empty => new MiddlewareTCPSpecInflightconnArgs();
    }
}