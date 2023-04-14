// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// Affinity of the component. Override the cluster-level one if present
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecMasterAffinity
    {
        /// <summary>
        /// Describes node affinity scheduling rules for the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinity NodeAffinity;
        /// <summary>
        /// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityPodaffinity PodAffinity;
        /// <summary>
        /// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityPodantiaffinity PodAntiAffinity;

        [OutputConstructor]
        private SeaweedSpecMasterAffinity(
            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityNodeaffinity nodeAffinity,

            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityPodaffinity podAffinity,

            Pulumi.Kubernetes.Types.Outputs.Seaweed.V1.SeaweedSpecMasterAffinityPodantiaffinity podAntiAffinity)
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
        }
    }
}
