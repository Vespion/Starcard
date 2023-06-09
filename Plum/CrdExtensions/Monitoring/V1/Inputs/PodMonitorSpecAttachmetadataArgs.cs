// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Attaches node metadata to discovered targets. Requires Prometheus v2.35.0 and above.
    /// </summary>
    public class PodMonitorSpecAttachmetadataArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// When set to true, Prometheus must have permissions to get Nodes.
        /// </summary>
        [Input("node")]
        public Input<bool>? Node { get; set; }

        public PodMonitorSpecAttachmetadataArgs()
        {
        }
        public static new PodMonitorSpecAttachmetadataArgs Empty => new PodMonitorSpecAttachmetadataArgs();
    }
}
