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
    /// ConfigMapKeySelector contains enough information to let you locate the key of a ConfigMap
    /// </summary>
    public class ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsConfigmaprefsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key to select
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Name of the referent.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsConfigmaprefsArgs()
        {
        }
        public static new ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsConfigmaprefsArgs Empty => new ClusterSpecBootstrapInitdbPostinitapplicationsqlrefsConfigmaprefsArgs();
    }
}
