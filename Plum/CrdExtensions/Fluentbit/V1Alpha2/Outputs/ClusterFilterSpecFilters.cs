// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2
{

    [OutputType]
    public sealed class ClusterFilterSpecFilters
    {
        /// <summary>
        /// Aws defines a Aws configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersAws Aws;
        /// <summary>
        /// CustomPlugin defines a Custom plugin configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersCustomplugin CustomPlugin;
        /// <summary>
        /// Grep defines Grep Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersGrep Grep;
        /// <summary>
        /// Kubernetes defines Kubernetes Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersKubernetes Kubernetes;
        /// <summary>
        /// Lua defines Lua Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersLua Lua;
        /// <summary>
        /// Modify defines Modify Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModify Modify;
        /// <summary>
        /// Multiline defines a Multiline configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersMultiline Multiline;
        /// <summary>
        /// Nest defines Nest Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersNest Nest;
        /// <summary>
        /// Parser defines Parser Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersParser Parser;
        /// <summary>
        /// RecordModifier defines Record Modifier Filter configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersRecordmodifier RecordModifier;
        /// <summary>
        /// RewriteTag defines a RewriteTag configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersRewritetag RewriteTag;
        /// <summary>
        /// Throttle defines a Throttle configuration.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersThrottle Throttle;

        [OutputConstructor]
        private ClusterFilterSpecFilters(
            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersAws aws,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersCustomplugin customPlugin,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersGrep grep,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersKubernetes kubernetes,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersLua lua,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersModify modify,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersMultiline multiline,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersNest nest,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersParser parser,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersRecordmodifier recordModifier,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersRewritetag rewriteTag,

            Pulumi.Kubernetes.Types.Outputs.Fluentbit.V1Alpha2.ClusterFilterSpecFiltersThrottle throttle)
        {
            Aws = aws;
            CustomPlugin = customPlugin;
            Grep = grep;
            Kubernetes = kubernetes;
            Lua = lua;
            Modify = modify;
            Multiline = multiline;
            Nest = nest;
            Parser = parser;
            RecordModifier = recordModifier;
            RewriteTag = rewriteTag;
            Throttle = throttle;
        }
    }
}
