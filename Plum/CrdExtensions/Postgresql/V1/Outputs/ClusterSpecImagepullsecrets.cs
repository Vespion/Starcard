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
    /// LocalObjectReference contains enough information to let you locate a local object with a known type inside the same namespace
    /// </summary>
    [OutputType]
    public sealed class ClusterSpecImagepullsecrets
    {
        /// <summary>
        /// Name of the referent.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ClusterSpecImagepullsecrets(string name)
        {
            Name = name;
        }
    }
}