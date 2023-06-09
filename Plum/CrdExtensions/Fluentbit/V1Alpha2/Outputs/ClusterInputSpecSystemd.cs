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
    /// Systemd defines Systemd Input configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterInputSpecSystemd
    {
        /// <summary>
        /// Specify the database file to keep track of monitored files and offsets.
        /// </summary>
        public readonly string Db;
        /// <summary>
        /// Set a default synchronization (I/O) method. values: Extra, Full, Normal, Off. This flag affects how the internal SQLite engine do synchronization to disk, for more details about each option please refer to this section. note: this option was introduced on Fluent Bit v1.4.6.
        /// </summary>
        public readonly string DbSync;
        /// <summary>
        /// When Fluent Bit starts, the Journal might have a high number of logs in the queue. In order to avoid delays and reduce memory usage, this option allows to specify the maximum number of log entries that can be processed per round. Once the limit is reached, Fluent Bit will continue processing the remaining log entries once Journald performs the notification.
        /// </summary>
        public readonly int MaxEntries;
        /// <summary>
        /// Set a maximum number of fields (keys) allowed per record.
        /// </summary>
        public readonly int MaxFields;
        /// <summary>
        /// Optional path to the Systemd journal directory, if not set, the plugin will use default paths to read local-only logs.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Start reading new entries. Skip entries already stored in Journald.
        /// </summary>
        public readonly string ReadFromTail;
        /// <summary>
        /// Remove the leading underscore of the Journald field (key). For example the Journald field _PID becomes the key PID.
        /// </summary>
        public readonly string StripUnderscores;
        /// <summary>
        /// Allows to perform a query over logs that contains a specific Journald key/value pairs, e.g: _SYSTEMD_UNIT=UNIT. The Systemd_Filter option can be specified multiple times in the input section to apply multiple filters as required.
        /// </summary>
        public readonly ImmutableArray<string> SystemdFilter;
        /// <summary>
        /// Define the filter type when Systemd_Filter is specified multiple times. Allowed values are And and Or. With And a record is matched only when all of the Systemd_Filter have a match. With Or a record is matched when any of the Systemd_Filter has a match.
        /// </summary>
        public readonly string SystemdFilterType;
        /// <summary>
        /// The tag is used to route messages but on Systemd plugin there is an extra functionality: if the tag includes a star/wildcard, it will be expanded with the Systemd Unit file (e.g: host.* =&gt; host.UNIT_NAME).
        /// </summary>
        public readonly string Tag;

        [OutputConstructor]
        private ClusterInputSpecSystemd(
            string db,

            string dbSync,

            int maxEntries,

            int maxFields,

            string path,

            string readFromTail,

            string stripUnderscores,

            ImmutableArray<string> systemdFilter,

            string systemdFilterType,

            string tag)
        {
            Db = db;
            DbSync = dbSync;
            MaxEntries = maxEntries;
            MaxFields = maxFields;
            Path = path;
            ReadFromTail = readFromTail;
            StripUnderscores = stripUnderscores;
            SystemdFilter = systemdFilter;
            SystemdFilterType = systemdFilterType;
            Tag = tag;
        }
    }
}
