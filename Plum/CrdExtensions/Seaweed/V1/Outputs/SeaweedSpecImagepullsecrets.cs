// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Seaweed.V1
{

    /// <summary>
    /// LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.
    /// </summary>
    [OutputType]
    public sealed class SeaweedSpecImagepullsecrets
    {
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private SeaweedSpecImagepullsecrets(string name)
        {
            Name = name;
        }
    }
}
