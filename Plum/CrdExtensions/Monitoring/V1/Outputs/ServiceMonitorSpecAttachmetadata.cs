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
    /// Attaches node metadata to discovered targets. Requires Prometheus v2.37.0 and above.
    /// </summary>
    [OutputType]
    public sealed class ServiceMonitorSpecAttachmetadata
    {
        /// <summary>
        /// When set to true, Prometheus must have permissions to get Nodes.
        /// </summary>
        public readonly bool Node;

        [OutputConstructor]
        private ServiceMonitorSpecAttachmetadata(bool node)
        {
            Node = node;
        }
    }
}