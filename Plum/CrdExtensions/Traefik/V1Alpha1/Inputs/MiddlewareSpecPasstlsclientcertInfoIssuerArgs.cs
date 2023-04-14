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
    /// Issuer defines the client certificate issuer details to add to the X-Forwarded-Tls-Client-Cert-Info header.
    /// </summary>
    public class MiddlewareSpecPasstlsclientcertInfoIssuerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CommonName defines whether to add the organizationalUnit information into the issuer.
        /// </summary>
        [Input("commonName")]
        public Input<bool>? CommonName { get; set; }

        /// <summary>
        /// Country defines whether to add the country information into the issuer.
        /// </summary>
        [Input("country")]
        public Input<bool>? Country { get; set; }

        /// <summary>
        /// DomainComponent defines whether to add the domainComponent information into the issuer.
        /// </summary>
        [Input("domainComponent")]
        public Input<bool>? DomainComponent { get; set; }

        /// <summary>
        /// Locality defines whether to add the locality information into the issuer.
        /// </summary>
        [Input("locality")]
        public Input<bool>? Locality { get; set; }

        /// <summary>
        /// Organization defines whether to add the organization information into the issuer.
        /// </summary>
        [Input("organization")]
        public Input<bool>? Organization { get; set; }

        /// <summary>
        /// Province defines whether to add the province information into the issuer.
        /// </summary>
        [Input("province")]
        public Input<bool>? Province { get; set; }

        /// <summary>
        /// SerialNumber defines whether to add the serialNumber information into the issuer.
        /// </summary>
        [Input("serialNumber")]
        public Input<bool>? SerialNumber { get; set; }

        public MiddlewareSpecPasstlsclientcertInfoIssuerArgs()
        {
        }
        public static new MiddlewareSpecPasstlsclientcertInfoIssuerArgs Empty => new MiddlewareSpecPasstlsclientcertInfoIssuerArgs();
    }
}