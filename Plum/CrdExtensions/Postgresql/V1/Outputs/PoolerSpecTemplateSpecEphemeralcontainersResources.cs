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
    /// Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecEphemeralcontainersResources
    {
        /// <summary>
        /// Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container. 
        ///  This is an alpha field and requires enabling the DynamicResourceAllocation feature gate. 
        ///  This field is immutable.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersResourcesClaims> Claims;
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public readonly ImmutableDictionary<string, Union<int, string>> Limits;
        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public readonly ImmutableDictionary<string, Union<int, string>> Requests;

        [OutputConstructor]
        private PoolerSpecTemplateSpecEphemeralcontainersResources(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersResourcesClaims> claims,

            ImmutableDictionary<string, Union<int, string>> limits,

            ImmutableDictionary<string, Union<int, string>> requests)
        {
            Claims = claims;
            Limits = limits;
            Requests = requests;
        }
    }
}
