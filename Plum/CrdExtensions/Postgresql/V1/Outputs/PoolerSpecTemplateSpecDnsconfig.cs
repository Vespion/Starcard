// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecDnsconfig
    {
        /// <summary>
        /// A list of DNS name server IP addresses. This will be appended to the base nameservers generated from DNSPolicy. Duplicated nameservers will be removed.
        /// </summary>
        public readonly ImmutableArray<string> Nameservers;
        /// <summary>
        /// A list of DNS resolver options. This will be merged with the base options generated from DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will override those that appear in the base DNSPolicy.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecDnsconfigOptions> Options;
        /// <summary>
        /// A list of DNS search domains for host-name lookup. This will be appended to the base search paths generated from DNSPolicy. Duplicated search paths will be removed.
        /// </summary>
        public readonly ImmutableArray<string> Searches;

        [OutputConstructor]
        private PoolerSpecTemplateSpecDnsconfig(
            ImmutableArray<string> nameservers,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecDnsconfigOptions> options,

            ImmutableArray<string> searches)
        {
            Nameservers = nameservers;
            Options = options;
            Searches = searches;
        }
    }
}
