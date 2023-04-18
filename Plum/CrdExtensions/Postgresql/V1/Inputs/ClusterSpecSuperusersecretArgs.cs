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
    /// The secret containing the superuser password. If not defined a new secret will be created with a randomly generated password
    /// </summary>
    public class ClusterSpecSuperusersecretArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the referent.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ClusterSpecSuperusersecretArgs()
        {
        }
        public static new ClusterSpecSuperusersecretArgs Empty => new ClusterSpecSuperusersecretArgs();
    }
}