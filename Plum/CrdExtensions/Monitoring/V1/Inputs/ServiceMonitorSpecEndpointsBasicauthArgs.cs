// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// BasicAuth allow an endpoint to authenticate over basic authentication More info: https://prometheus.io/docs/operating/configuration/#endpoints
    /// </summary>
    public class ServiceMonitorSpecEndpointsBasicauthArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The secret in the service monitor namespace that contains the password for authentication.
        /// </summary>
        [Input("password")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicauthPasswordArgs>? Password { get; set; }

        /// <summary>
        /// The secret in the service monitor namespace that contains the username for authentication.
        /// </summary>
        [Input("username")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicauthUsernameArgs>? Username { get; set; }

        public ServiceMonitorSpecEndpointsBasicauthArgs()
        {
        }
        public static new ServiceMonitorSpecEndpointsBasicauthArgs Empty => new ServiceMonitorSpecEndpointsBasicauthArgs();
    }
}
