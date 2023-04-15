// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    /// <summary>
    /// The secret's key that contains the credentials of the request
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecAuthorizationCredentials
    {
        /// <summary>
        /// The key of the secret to select from.  Must be a valid secret key.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specify whether the Secret or its key must be defined
        /// </summary>
        public readonly bool Optional;

        [OutputConstructor]
        private ProbeSpecAuthorizationCredentials(
            string key,

            string name,

            bool optional)
        {
            Key = key;
            Name = name;
            Optional = optional;
        }
    }
}
