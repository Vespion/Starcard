// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// ServiceSpec is a subset of the original k8s spec
    /// </summary>
    public class SeaweedSpecVolumeServiceArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;

        /// <summary>
        /// Additional annotations of the kubernetes service object
        /// </summary>
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// ClusterIP is the clusterIP of service
        /// </summary>
        [Input("clusterIP")]
        public Input<string>? ClusterIP { get; set; }

        /// <summary>
        /// LoadBalancerIP is the loadBalancerIP of service
        /// </summary>
        [Input("loadBalancerIP")]
        public Input<string>? LoadBalancerIP { get; set; }

        /// <summary>
        /// Type of the real kubernetes service
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public SeaweedSpecVolumeServiceArgs()
        {
        }
        public static new SeaweedSpecVolumeServiceArgs Empty => new SeaweedSpecVolumeServiceArgs();
    }
}