// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
    /// </summary>
    public class SeaweedSpecMasterEnvValuefromResourcefieldrefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container name: required for volumes, optional for env vars
        /// </summary>
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        /// <summary>
        /// Specifies the output format of the exposed resources, defaults to "1"
        /// </summary>
        [Input("divisor")]
        public InputUnion<int, string>? Divisor { get; set; }

        /// <summary>
        /// Required: resource to select
        /// </summary>
        [Input("resource", required: true)]
        public Input<string> Resource { get; set; } = null!;

        public SeaweedSpecMasterEnvValuefromResourcefieldrefArgs()
        {
        }
        public static new SeaweedSpecMasterEnvValuefromResourcefieldrefArgs Empty => new SeaweedSpecMasterEnvValuefromResourcefieldrefArgs();
    }
}
