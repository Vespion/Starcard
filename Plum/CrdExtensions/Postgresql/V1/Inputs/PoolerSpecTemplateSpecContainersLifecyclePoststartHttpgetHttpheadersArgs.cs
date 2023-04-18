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
    /// HTTPHeader describes a custom header to be used in HTTP probes
    /// </summary>
    public class PoolerSpecTemplateSpecContainersLifecyclePoststartHttpgetHttpheadersArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The header field name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The header field value
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public PoolerSpecTemplateSpecContainersLifecyclePoststartHttpgetHttpheadersArgs()
        {
        }
        public static new PoolerSpecTemplateSpecContainersLifecyclePoststartHttpgetHttpheadersArgs Empty => new PoolerSpecTemplateSpecContainersLifecyclePoststartHttpgetHttpheadersArgs();
    }
}
