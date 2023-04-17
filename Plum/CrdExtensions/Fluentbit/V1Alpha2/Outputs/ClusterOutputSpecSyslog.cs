// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2
{

    /// <summary>
    /// Syslog defines Syslog Output configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterOutputSpecSyslog
    {
        /// <summary>
        /// Host domain or IP address of the remote Syslog server.
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// Mode of the desired transport type, the available options are tcp, tls and udp.
        /// </summary>
        public readonly string Mode;
        /// <summary>
        /// TCP or UDP port of the remote Syslog server.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Key name from the original record that contains the application name that generated the message.
        /// </summary>
        public readonly string SyslogAppnameKey;
        /// <summary>
        /// Key from the original record that contains the Syslog facility number.
        /// </summary>
        public readonly string SyslogFacilityKey;
        /// <summary>
        /// Syslog protocol format to use, the available options are rfc3164 and rfc5424.
        /// </summary>
        public readonly string SyslogFormat;
        /// <summary>
        /// Key name from the original record that contains the hostname that generated the message.
        /// </summary>
        public readonly string SyslogHostnameKey;
        /// <summary>
        /// Maximum size allowed per message, in bytes.
        /// </summary>
        public readonly int SyslogMaxSize;
        /// <summary>
        /// Key name from the original record that contains the Message ID associated to the message.
        /// </summary>
        public readonly string SyslogMessageIDKey;
        /// <summary>
        /// Key key name that contains the message to deliver.
        /// </summary>
        public readonly string SyslogMessageKey;
        /// <summary>
        /// Key name from the original record that contains the Process ID that generated the message.
        /// </summary>
        public readonly string SyslogProcessIDKey;
        /// <summary>
        /// Key name from the original record that contains the Structured Data (SD) content.
        /// </summary>
        public readonly string SyslogSDKey;
        /// <summary>
        /// Key from the original record that contains the Syslog severity number.
        /// </summary>
        public readonly string SyslogSeverityKey;
        /// <summary>
        /// Syslog output plugin supports TTL/SSL, for more details about the properties available and general configuration, please refer to the TLS/SSL section.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecSyslogTls Tls;

        [OutputConstructor]
        private ClusterOutputSpecSyslog(
            string host,

            string mode,

            int port,

            string syslogAppnameKey,

            string syslogFacilityKey,

            string syslogFormat,

            string syslogHostnameKey,

            int syslogMaxSize,

            string syslogMessageIDKey,

            string syslogMessageKey,

            string syslogProcessIDKey,

            string syslogSDKey,

            string syslogSeverityKey,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterOutputSpecSyslogTls tls)
        {
            Host = host;
            Mode = mode;
            Port = port;
            SyslogAppnameKey = syslogAppnameKey;
            SyslogFacilityKey = syslogFacilityKey;
            SyslogFormat = syslogFormat;
            SyslogHostnameKey = syslogHostnameKey;
            SyslogMaxSize = syslogMaxSize;
            SyslogMessageIDKey = syslogMessageIDKey;
            SyslogMessageKey = syslogMessageKey;
            SyslogProcessIDKey = syslogProcessIDKey;
            SyslogSDKey = syslogSDKey;
            SyslogSeverityKey = syslogSeverityKey;
            Tls = tls;
        }
    }
}
