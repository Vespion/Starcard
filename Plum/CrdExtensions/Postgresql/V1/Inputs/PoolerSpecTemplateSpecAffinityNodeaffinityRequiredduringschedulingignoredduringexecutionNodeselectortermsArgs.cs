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
    /// A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
    /// </summary>
    public class PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs : global::Pulumi.ResourceArgs
    {
        [Input("matchExpressions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs>? _matchExpressions;

        /// <summary>
        /// A list of node selector requirements by node's labels.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs> MatchExpressions
        {
            get => _matchExpressions ?? (_matchExpressions = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchexpressionsArgs>());
            set => _matchExpressions = value;
        }

        [Input("matchFields")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs>? _matchFields;

        /// <summary>
        /// A list of node selector requirements by node's fields.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs> MatchFields
        {
            get => _matchFields ?? (_matchFields = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsMatchfieldsArgs>());
            set => _matchFields = value;
        }

        public PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs()
        {
        }
        public static new PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs Empty => new PoolerSpecTemplateSpecAffinityNodeaffinityRequiredduringschedulingignoredduringexecutionNodeselectortermsArgs();
    }
}
