// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// CustomPlugin defines a Custom plugin configuration.
    /// </summary>
    public class ClusterFilterSpecFiltersCustompluginArgs : global::Pulumi.ResourceArgs
    {
        [Input("config")]
        public Input<string>? Config { get; set; }

        public ClusterFilterSpecFiltersCustompluginArgs()
        {
        }
        public static new ClusterFilterSpecFiltersCustompluginArgs Empty => new ClusterFilterSpecFiltersCustompluginArgs();
    }
}