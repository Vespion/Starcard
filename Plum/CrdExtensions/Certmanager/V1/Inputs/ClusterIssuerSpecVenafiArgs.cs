// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Certmanager.V1
{

    /// <summary>
    /// Venafi configures this issuer to sign certificates using a Venafi TPP or Venafi Cloud policy zone.
    /// </summary>
    public class ClusterIssuerSpecVenafiArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud specifies the Venafi cloud configuration settings. Only one of TPP or Cloud may be specified.
        /// </summary>
        [Input("cloud")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.ClusterIssuerSpecVenafiCloudArgs>? Cloud { get; set; }

        /// <summary>
        /// TPP specifies Trust Protection Platform configuration settings. Only one of TPP or Cloud may be specified.
        /// </summary>
        [Input("tpp")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Certmanager.V1.ClusterIssuerSpecVenafiTppArgs>? Tpp { get; set; }

        /// <summary>
        /// Zone is the Venafi Policy Zone to use for this issuer. All requests made to the Venafi platform will be restricted by the named zone policy. This field is required.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public ClusterIssuerSpecVenafiArgs()
        {
        }
        public static new ClusterIssuerSpecVenafiArgs Empty => new ClusterIssuerSpecVenafiArgs();
    }
}