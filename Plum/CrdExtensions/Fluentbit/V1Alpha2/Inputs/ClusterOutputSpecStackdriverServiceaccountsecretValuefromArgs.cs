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
    public class ClusterOutputSpecStackdriverServiceaccountsecretValuefromArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Selects a key of a secret in the pod's namespace
        /// </summary>
        [Input("secretKeyRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecStackdriverServiceaccountsecretValuefromSecretkeyrefArgs>? SecretKeyRef { get; set; }

        public ClusterOutputSpecStackdriverServiceaccountsecretValuefromArgs()
        {
        }
        public static new ClusterOutputSpecStackdriverServiceaccountsecretValuefromArgs Empty => new ClusterOutputSpecStackdriverServiceaccountsecretValuefromArgs();
    }
}
