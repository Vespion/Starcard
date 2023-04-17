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
    /// The plugin supports the following rules
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersModifyRules
    {
        /// <summary>
        /// Add a key/value pair with key KEY and value VALUE if KEY does not exist
        /// </summary>
        public readonly ImmutableDictionary<string, string> Add;
        /// <summary>
        /// Copy a key/value pair with key KEY to COPIED_KEY if KEY exists AND COPIED_KEY does not exist
        /// </summary>
        public readonly ImmutableDictionary<string, string> Copy;
        /// <summary>
        /// Copy a key/value pair with key KEY to COPIED_KEY if KEY exists. If COPIED_KEY already exists, this field is overwritten
        /// </summary>
        public readonly ImmutableDictionary<string, string> HardCopy;
        /// <summary>
        /// Rename a key/value pair with key KEY to RENAMED_KEY if KEY exists. If RENAMED_KEY already exists, this field is overwritten
        /// </summary>
        public readonly ImmutableDictionary<string, string> HardRename;
        /// <summary>
        /// Remove a key/value pair with key KEY if it exists
        /// </summary>
        public readonly string Remove;
        /// <summary>
        /// Remove all key/value pairs with key matching regexp KEY
        /// </summary>
        public readonly string RemoveRegex;
        /// <summary>
        /// Remove all key/value pairs with key matching wildcard KEY
        /// </summary>
        public readonly string RemoveWildcard;
        /// <summary>
        /// Rename a key/value pair with key KEY to RENAMED_KEY if KEY exists AND RENAMED_KEY does not exist
        /// </summary>
        public readonly ImmutableDictionary<string, string> Rename;
        /// <summary>
        /// Add a key/value pair with key KEY and value VALUE. If KEY already exists, this field is overwritten
        /// </summary>
        public readonly ImmutableDictionary<string, string> Set;

        [OutputConstructor]
        private ClusterFilterSpecFiltersModifyRules(
            ImmutableDictionary<string, string> add,

            ImmutableDictionary<string, string> copy,

            ImmutableDictionary<string, string> hardCopy,

            ImmutableDictionary<string, string> hardRename,

            string remove,

            string removeRegex,

            string removeWildcard,

            ImmutableDictionary<string, string> rename,

            ImmutableDictionary<string, string> set)
        {
            Add = add;
            Copy = copy;
            HardCopy = hardCopy;
            HardRename = hardRename;
            Remove = remove;
            RemoveRegex = removeRegex;
            RemoveWildcard = removeWildcard;
            Rename = rename;
            Set = set;
        }
    }
}