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
    /// The auth query secret version
    /// </summary>
    public class PoolerStatusSecretsPgbouncersecretsAuthqueryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the secret
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ResourceVersion of the secret
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public PoolerStatusSecretsPgbouncersecretsAuthqueryArgs()
        {
        }
        public static new PoolerStatusSecretsPgbouncersecretsAuthqueryArgs Empty => new PoolerStatusSecretsPgbouncersecretsAuthqueryArgs();
    }
}
