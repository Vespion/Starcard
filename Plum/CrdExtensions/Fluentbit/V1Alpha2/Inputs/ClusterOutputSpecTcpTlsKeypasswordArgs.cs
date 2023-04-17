// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Optional password for tls.key_file file
    /// </summary>
    public class ClusterOutputSpecTcpTlsKeypasswordArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ValueSource defines how to find a value's key.
        /// </summary>
        [Input("valueFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecTcpTlsKeypasswordValuefromArgs>? ValueFrom { get; set; }

        public ClusterOutputSpecTcpTlsKeypasswordArgs()
        {
        }
        public static new ClusterOutputSpecTcpTlsKeypasswordArgs Empty => new ClusterOutputSpecTcpTlsKeypasswordArgs();
    }
}
