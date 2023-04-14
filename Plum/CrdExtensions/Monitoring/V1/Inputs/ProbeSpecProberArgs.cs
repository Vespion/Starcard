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
    /// Specification for the prober to use for probing targets. The prober.URL parameter is required. Targets cannot be probed if left empty.
    /// </summary>
    public class ProbeSpecProberArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Path to collect metrics from. Defaults to `/probe`.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// Optional ProxyURL.
        /// </summary>
        [Input("proxyUrl")]
        public Input<string>? ProxyUrl { get; set; }

        /// <summary>
        /// HTTP scheme to use for scraping. Defaults to `http`.
        /// </summary>
        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        /// <summary>
        /// Mandatory URL of the prober.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public ProbeSpecProberArgs()
        {
            Path = "/probe";
        }
        public static new ProbeSpecProberArgs Empty => new ProbeSpecProberArgs();
    }
}