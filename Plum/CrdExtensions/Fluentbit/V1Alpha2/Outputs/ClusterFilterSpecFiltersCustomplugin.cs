// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// CustomPlugin defines a Custom plugin configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersCustomplugin
    {
        public readonly string Config;

        [OutputConstructor]
        private ClusterFilterSpecFiltersCustomplugin(string config)
        {
            Config = config;
        }
    }
}
