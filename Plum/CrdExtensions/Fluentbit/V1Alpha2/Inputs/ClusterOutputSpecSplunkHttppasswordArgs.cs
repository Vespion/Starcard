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
    /// Password for user defined in HTTP_User
    /// </summary>
    public class ClusterOutputSpecSplunkHttppasswordArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ValueSource defines how to find a value's key.
        /// </summary>
        [Input("valueFrom")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecSplunkHttppasswordValuefromArgs>? ValueFrom { get; set; }

        public ClusterOutputSpecSplunkHttppasswordArgs()
        {
        }
        public static new ClusterOutputSpecSplunkHttppasswordArgs Empty => new ClusterOutputSpecSplunkHttppasswordArgs();
    }
}
