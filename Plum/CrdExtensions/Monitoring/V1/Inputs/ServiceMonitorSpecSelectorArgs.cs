// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Selector to select Endpoints objects.
    /// </summary>
    public class ServiceMonitorSpecSelectorArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecSelectorMatchexpressionsArgs>? _matchExpressions;

        /// <summary>
        /// matchExpressions is a list of label selector requirements. The requirements are ANDed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecSelectorMatchexpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.ServiceMonitorSpecSelectorMatchexpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchLabels")]
        private InputMap<string>? _matchLabels;

        /// <summary>
        /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        /// </summary>
        public InputMap<string> MatchLabels
        {
            get => _matchLabels ?? (_matchLabels = new InputMap<string>());
            set => _matchLabels = value;
        }

        public ServiceMonitorSpecSelectorArgs()
        {
        }
        public static new ServiceMonitorSpecSelectorArgs Empty => new ServiceMonitorSpecSelectorArgs();
    }
}
