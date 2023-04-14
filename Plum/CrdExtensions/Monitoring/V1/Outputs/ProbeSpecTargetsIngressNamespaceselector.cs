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
    /// From which namespaces to select Ingress objects.
    /// </summary>
    [OutputType]
    public sealed class ProbeSpecTargetsIngressNamespaceselector
    {
        /// <summary>
        /// Boolean describing whether all namespaces are selected in contrast to a list restricting them.
        /// </summary>
        public readonly bool Any;
        /// <summary>
        /// List of namespace names to select from.
        /// </summary>
        public readonly ImmutableArray<string> MatchNames;

        [OutputConstructor]
        private ProbeSpecTargetsIngressNamespaceselector(
            bool any,

            ImmutableArray<string> matchNames)
        {
            Any = any;
            MatchNames = matchNames;
        }
    }
}
