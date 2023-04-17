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
    /// Syslog defines Syslog Output configuration.
    /// </summary>
    public class ClusterOutputSpecSyslogArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host domain or IP address of the remote Syslog server.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Mode of the desired transport type, the available options are tcp, tls and udp.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// TCP or UDP port of the remote Syslog server.
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Key name from the original record that contains the application name that generated the message.
        /// </summary>
        [Input("syslogAppnameKey")]
        public Input<string>? SyslogAppnameKey { get; set; }

        /// <summary>
        /// Key from the original record that contains the Syslog facility number.
        /// </summary>
        [Input("syslogFacilityKey")]
        public Input<string>? SyslogFacilityKey { get; set; }

        /// <summary>
        /// Syslog protocol format to use, the available options are rfc3164 and rfc5424.
        /// </summary>
        [Input("syslogFormat")]
        public Input<string>? SyslogFormat { get; set; }

        /// <summary>
        /// Key name from the original record that contains the hostname that generated the message.
        /// </summary>
        [Input("syslogHostnameKey")]
        public Input<string>? SyslogHostnameKey { get; set; }

        /// <summary>
        /// Maximum size allowed per message, in bytes.
        /// </summary>
        [Input("syslogMaxSize")]
        public Input<int>? SyslogMaxSize { get; set; }

        /// <summary>
        /// Key name from the original record that contains the Message ID associated to the message.
        /// </summary>
        [Input("syslogMessageIDKey")]
        public Input<string>? SyslogMessageIDKey { get; set; }

        /// <summary>
        /// Key key name that contains the message to deliver.
        /// </summary>
        [Input("syslogMessageKey")]
        public Input<string>? SyslogMessageKey { get; set; }

        /// <summary>
        /// Key name from the original record that contains the Process ID that generated the message.
        /// </summary>
        [Input("syslogProcessIDKey")]
        public Input<string>? SyslogProcessIDKey { get; set; }

        /// <summary>
        /// Key name from the original record that contains the Structured Data (SD) content.
        /// </summary>
        [Input("syslogSDKey")]
        public Input<string>? SyslogSDKey { get; set; }

        /// <summary>
        /// Key from the original record that contains the Syslog severity number.
        /// </summary>
        [Input("syslogSeverityKey")]
        public Input<string>? SyslogSeverityKey { get; set; }

        /// <summary>
        /// Syslog output plugin supports TTL/SSL, for more details about the properties available and general configuration, please refer to the TLS/SSL section.
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterOutputSpecSyslogTlsArgs>? Tls { get; set; }

        public ClusterOutputSpecSyslogArgs()
        {
        }
        public static new ClusterOutputSpecSyslogArgs Empty => new ClusterOutputSpecSyslogArgs();
    }
}
