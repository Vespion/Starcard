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
    /// The secret or configmap containing the OAuth2 client id
    /// </summary>
    [OutputType]
    public sealed class ServiceMonitorSpecEndpointsOauth2Clientid
    {
        /// <summary>
        /// ConfigMap containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientidConfigmap ConfigMap;
        /// <summary>
        /// Secret containing data to use for the targets.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientidSecret Secret;

        [OutputConstructor]
        private ServiceMonitorSpecEndpointsOauth2Clientid(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientidConfigmap configMap,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsOauth2ClientidSecret secret)
        {
            ConfigMap = configMap;
            Secret = secret;
        }
    }
}
