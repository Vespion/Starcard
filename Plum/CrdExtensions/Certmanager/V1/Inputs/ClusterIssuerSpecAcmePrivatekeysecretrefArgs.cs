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
    /// PrivateKey is the name of a Kubernetes Secret resource that will be used to store the automatically generated ACME account private key. Optionally, a `key` may be specified to select a specific entry within the named Secret resource. If `key` is not specified, a default of `tls.key` will be used.
    /// </summary>
    public class ClusterIssuerSpecAcmePrivatekeysecretrefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key of the entry in the Secret resource's `data` field to be used. Some instances of this field may be defaulted, in others it may be required.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// Name of the resource being referred to. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterIssuerSpecAcmePrivatekeysecretrefArgs()
        {
        }
        public static new ClusterIssuerSpecAcmePrivatekeysecretrefArgs Empty => new ClusterIssuerSpecAcmePrivatekeysecretrefArgs();
    }
}
