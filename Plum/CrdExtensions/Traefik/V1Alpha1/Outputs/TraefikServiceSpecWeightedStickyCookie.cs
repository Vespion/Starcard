// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Cookie defines the sticky cookie configuration.
    /// </summary>
    [OutputType]
    public sealed class TraefikServiceSpecWeightedStickyCookie
    {
        /// <summary>
        /// HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.
        /// </summary>
        public readonly bool HttpOnly;
        /// <summary>
        /// Name defines the Cookie name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// SameSite defines the same site policy. More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
        /// </summary>
        public readonly string SameSite;
        /// <summary>
        /// Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).
        /// </summary>
        public readonly bool Secure;

        [OutputConstructor]
        private TraefikServiceSpecWeightedStickyCookie(
            bool httpOnly,

            string name,

            string sameSite,

            bool secure)
        {
            HttpOnly = httpOnly;
            Name = name;
            SameSite = sameSite;
            Secure = secure;
        }
    }
}
