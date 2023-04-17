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
    /// RecordModifier defines Record Modifier Filter configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersRecordmodifier
    {
        /// <summary>
        /// Alias for the plugin
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// If the key is not matched, that field is removed.
        /// </summary>
        public readonly ImmutableArray<string> AllowlistKeys;
        /// <summary>
        /// Append fields. This parameter needs key and value pair.
        /// </summary>
        public readonly ImmutableArray<string> Records;
        /// <summary>
        /// If the key is matched, that field is removed.
        /// </summary>
        public readonly ImmutableArray<string> RemoveKeys;
        /// <summary>
        /// RetryLimit describes how many times fluent-bit should retry to send data to a specific output. If set to false fluent-bit will try indefinetly. If set to any integer N&gt;0 it will try at most N+1 times. Leading zeros are not allowed (values such as 007, 0150, 01 do not work). If this property is not defined fluent-bit will use the default value: 1.
        /// </summary>
        public readonly string RetryLimit;
        /// <summary>
        /// If set, the plugin appends uuid to each record. The value assigned becomes the key in the map.
        /// </summary>
        public readonly ImmutableArray<string> UuidKeys;
        /// <summary>
        /// An alias of allowlistKeys for backwards compatibility.
        /// </summary>
        public readonly ImmutableArray<string> WhitelistKeys;

        [OutputConstructor]
        private ClusterFilterSpecFiltersRecordmodifier(
            string alias,

            ImmutableArray<string> allowlistKeys,

            ImmutableArray<string> records,

            ImmutableArray<string> removeKeys,

            string retryLimit,

            ImmutableArray<string> uuidKeys,

            ImmutableArray<string> whitelistKeys)
        {
            Alias = alias;
            AllowlistKeys = allowlistKeys;
            Records = records;
            RemoveKeys = removeKeys;
            RetryLimit = retryLimit;
            UuidKeys = uuidKeys;
            WhitelistKeys = whitelistKeys;
        }
    }
}