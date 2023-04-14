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
    /// OAuth2 for the URL. Only valid in Prometheus versions 2.27.0 and newer.
    /// </summary>
    public class ServiceMonitorSpecEndpointsOauth2Args : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The secret or configmap containing the OAuth2 client id
        /// </summary>
        [Input("clientId", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientidArgs> ClientId { get; set; } = null!;

        /// <summary>
        /// The secret containing the OAuth2 client secret
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientsecretArgs> ClientSecret { get; set; } = null!;

        [Input("endpointParams")]
        private InputMap<string>? _endpointParams;

        /// <summary>
        /// Parameters to append to the token URL
        /// </summary>
        public InputMap<string> EndpointParams
        {
            get => _endpointParams ?? (_endpointParams = new InputMap<string>());
            set => _endpointParams = value;
        }

        [Input("scopes")]
        private InputList<string>? _scopes;

        /// <summary>
        /// OAuth2 scopes used for the token request
        /// </summary>
        public InputList<string> Scopes
        {
            get => _scopes ?? (_scopes = new InputList<string>());
            set => _scopes = value;
        }

        /// <summary>
        /// The URL to fetch the token from
        /// </summary>
        [Input("tokenUrl", required: true)]
        public Input<string> TokenUrl { get; set; } = null!;

        public ServiceMonitorSpecEndpointsOauth2Args()
        {
        }
        public static new ServiceMonitorSpecEndpointsOauth2Args Empty => new ServiceMonitorSpecEndpointsOauth2Args();
    }
}
