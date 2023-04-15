// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Inputs.Seaweed.V1
{

    /// <summary>
    /// Selects a key of a ConfigMap.
    /// </summary>
    public class SeaweedSpecMasterEnvValuefromConfigmapkeyrefArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key to select.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specify whether the ConfigMap or its key must be defined
        /// </summary>
        [Input("optional")]
        public Input<bool>? Optional { get; set; }

        public SeaweedSpecMasterEnvValuefromConfigmapkeyrefArgs()
        {
        }
        public static new SeaweedSpecMasterEnvValuefromConfigmapkeyrefArgs Empty => new SeaweedSpecMasterEnvValuefromConfigmapkeyrefArgs();
    }
}
