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
    /// Lua defines Lua Filter configuration.
    /// </summary>
    public class ClusterFilterSpecFiltersLuaArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alias for the plugin
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        /// <summary>
        /// Lua function name that will be triggered to do filtering. It's assumed that the function is declared inside the Script defined above.
        /// </summary>
        [Input("call", required: true)]
        public Input<string> Call { get; set; } = null!;

        /// <summary>
        /// If enabled, Lua script will be executed in protected mode. It prevents to crash when invalid Lua script is executed. Default is true.
        /// </summary>
        [Input("protectedMode")]
        public Input<bool>? ProtectedMode { get; set; }

        /// <summary>
        /// RetryLimit describes how many times fluent-bit should retry to send data to a specific output. If set to false fluent-bit will try indefinetly. If set to any integer N&gt;0 it will try at most N+1 times. Leading zeros are not allowed (values such as 007, 0150, 01 do not work). If this property is not defined fluent-bit will use the default value: 1.
        /// </summary>
        [Input("retryLimit")]
        public Input<string>? RetryLimit { get; set; }

        /// <summary>
        /// Path to the Lua script that will be used.
        /// </summary>
        [Input("script", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersLuaScriptArgs> Script { get; set; } = null!;

        /// <summary>
        /// By default when the Lua script is invoked, the record timestamp is passed as a Floating number which might lead to loss precision when the data is converted back. If you desire timestamp precision enabling this option will pass the timestamp as a Lua table with keys sec for seconds since epoch and nsec for nanoseconds.
        /// </summary>
        [Input("timeAsTable")]
        public Input<bool>? TimeAsTable { get; set; }

        [Input("typeIntKey")]
        private InputList<string>? _typeIntKey;

        /// <summary>
        /// If these keys are matched, the fields are converted to integer. If more than one key, delimit by space. Note that starting from Fluent Bit v1.6 integer data types are preserved and not converted to double as in previous versions.
        /// </summary>
        public InputList<string> TypeIntKey
        {
            get => _typeIntKey ?? (_typeIntKey = new InputList<string>());
            set => _typeIntKey = value;
        }

        public ClusterFilterSpecFiltersLuaArgs()
        {
        }
        public static new ClusterFilterSpecFiltersLuaArgs Empty => new ClusterFilterSpecFiltersLuaArgs();
    }
}