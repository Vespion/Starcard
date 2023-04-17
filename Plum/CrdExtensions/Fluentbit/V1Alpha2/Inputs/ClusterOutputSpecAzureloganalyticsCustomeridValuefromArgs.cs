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
    /// ValueSource defines how to find a value's key.
    /// </summary>
    public class ClusterOutputSpecAzureloganalyticsCustomeridValuefromArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecAzureloganalyticsCustomeridValuefromSecretkeyrefArgs>? SecretKeyRef { get; set; }

        public ClusterOutputSpecAzureloganalyticsCustomeridValuefromArgs()
        {
        }
        public static new ClusterOutputSpecAzureloganalyticsCustomeridValuefromArgs Empty => new ClusterOutputSpecAzureloganalyticsCustomeridValuefromArgs();
    }
}
