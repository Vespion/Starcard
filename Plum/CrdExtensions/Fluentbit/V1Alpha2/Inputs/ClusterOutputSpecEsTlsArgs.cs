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
    /// Fluent Bit provides integrated support for Transport Layer Security (TLS) and it predecessor Secure Sockets Layer (SSL) respectively.
    /// </summary>
    public class ClusterOutputSpecEsTlsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute path to CA certificate file
        /// </summary>
        [Input("caFile")]
        public Input<string>? CaFile { get; set; }

        /// <summary>
        /// Absolute path to scan for certificate files
        /// </summary>
        [Input("caPath")]
        public Input<string>? CaPath { get; set; }

        /// <summary>
        /// Absolute path to Certificate file
        /// </summary>
        [Input("crtFile")]
        public Input<string>? CrtFile { get; set; }

        /// <summary>
        /// Set TLS debug verbosity level. It accept the following values: 0 (No debug), 1 (Error), 2 (State change), 3 (Informational) and 4 Verbose
        /// </summary>
        [Input("debug")]
        public Input<int>? Debug { get; set; }

        /// <summary>
        /// Absolute path to private Key file
        /// </summary>
        [Input("keyFile")]
        public Input<string>? KeyFile { get; set; }

        /// <summary>
        /// Optional password for tls.key_file file
        /// </summary>
        [Input("keyPassword")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecEsTlsKeypasswordArgs>? KeyPassword { get; set; }

        /// <summary>
        /// Force certificate validation
        /// </summary>
        [Input("verify")]
        public Input<bool>? Verify { get; set; }

        /// <summary>
        /// Hostname to be used for TLS SNI extension
        /// </summary>
        [Input("vhost")]
        public Input<string>? Vhost { get; set; }

        public ClusterOutputSpecEsTlsArgs()
        {
        }
        public static new ClusterOutputSpecEsTlsArgs Empty => new ClusterOutputSpecEsTlsArgs();
    }
}
