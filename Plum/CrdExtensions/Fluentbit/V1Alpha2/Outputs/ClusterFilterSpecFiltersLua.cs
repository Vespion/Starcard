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
    /// Lua defines Lua Filter configuration.
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersLua
    {
        /// <summary>
        /// Alias for the plugin
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// Lua function name that will be triggered to do filtering. It's assumed that the function is declared inside the Script defined above.
        /// </summary>
        public readonly string Call;
        /// <summary>
        /// If enabled, Lua script will be executed in protected mode. It prevents to crash when invalid Lua script is executed. Default is true.
        /// </summary>
        public readonly bool ProtectedMode;
        /// <summary>
        /// RetryLimit describes how many times fluent-bit should retry to send data to a specific output. If set to false fluent-bit will try indefinetly. If set to any integer N&gt;0 it will try at most N+1 times. Leading zeros are not allowed (values such as 007, 0150, 01 do not work). If this property is not defined fluent-bit will use the default value: 1.
        /// </summary>
        public readonly string RetryLimit;
        /// <summary>
        /// Path to the Lua script that will be used.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersLuaScript Script;
        /// <summary>
        /// By default when the Lua script is invoked, the record timestamp is passed as a Floating number which might lead to loss precision when the data is converted back. If you desire timestamp precision enabling this option will pass the timestamp as a Lua table with keys sec for seconds since epoch and nsec for nanoseconds.
        /// </summary>
        public readonly bool TimeAsTable;
        /// <summary>
        /// If these keys are matched, the fields are converted to integer. If more than one key, delimit by space. Note that starting from Fluent Bit v1.6 integer data types are preserved and not converted to double as in previous versions.
        /// </summary>
        public readonly ImmutableArray<string> TypeIntKey;

        [OutputConstructor]
        private ClusterFilterSpecFiltersLua(
            string alias,

            string call,

            bool protectedMode,

            string retryLimit,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersLuaScript script,

            bool timeAsTable,

            ImmutableArray<string> typeIntKey)
        {
            Alias = alias;
            Call = call;
            ProtectedMode = protectedMode;
            RetryLimit = retryLimit;
            Script = script;
            TimeAsTable = timeAsTable;
            TypeIntKey = typeIntKey;
        }
    }
}
