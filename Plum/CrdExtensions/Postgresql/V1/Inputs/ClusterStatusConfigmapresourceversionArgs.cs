// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Postgresql.V1
{

    /// <summary>
    /// The list of resource versions of the configmaps, managed by the operator. Every change here is done in the interest of the instance manager, which will refresh the configmap data
    /// </summary>
    public class ClusterStatusConfigmapresourceversionArgs : global::Pulumi.ResourceArgs
    {
        [Input("metrics")]
        private InputMap<string>? _metrics;

        /// <summary>
        /// A map with the versions of all the config maps used to pass metrics. Map keys are the config map names, map values are the versions
        /// </summary>
        public InputMap<string> Metrics
        {
            get => _metrics ?? (_metrics = new InputMap<string>());
            set => _metrics = value;
        }

        public ClusterStatusConfigmapresourceversionArgs()
        {
        }
        public static new ClusterStatusConfigmapresourceversionArgs Empty => new ClusterStatusConfigmapresourceversionArgs();
    }
}
