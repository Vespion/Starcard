// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// Certificate authority used when verifying server certificates.
    /// </summary>
    [OutputType]
    public sealed class PodMonitorSpecPodmetricsendpointsTlsconfigCa
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaConfigmap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaSecret Secret;

        [OutputConstructor]
        private PodMonitorSpecPodmetricsendpointsTlsconfigCa(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaConfigmap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.PodMonitorSpecPodmetricsendpointsTlsconfigCaSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
