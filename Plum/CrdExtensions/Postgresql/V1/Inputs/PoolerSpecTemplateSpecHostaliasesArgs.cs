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
    /// HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.
    /// </summary>
    public class PoolerSpecTemplateSpecHostaliasesArgs : global::Pulumi.ResourceArgs
    {
        [Input("hostnames")]
        private InputList<string>? _hostnames;

        /// <summary>
        /// Hostnames for the above IP address.
        /// </summary>
        public InputList<string> Hostnames
        {
            get => _hostnames ?? (_hostnames = new InputList<string>());
            set => _hostnames = value;
        }

        /// <summary>
        /// IP address of the host file entry.
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        public PoolerSpecTemplateSpecHostaliasesArgs()
        {
        }
        public static new PoolerSpecTemplateSpecHostaliasesArgs Empty => new PoolerSpecTemplateSpecHostaliasesArgs();
    }
}
