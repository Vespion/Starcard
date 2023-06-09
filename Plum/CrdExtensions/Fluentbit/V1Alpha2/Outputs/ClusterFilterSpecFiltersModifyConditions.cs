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
    /// The plugin supports the following conditions
    /// </summary>
    [OutputType]
    public sealed class ClusterFilterSpecFiltersModifyConditions
    {
        /// <summary>
        /// Is true if a key matches regex KEY
        /// </summary>
        public readonly string AKeyMatches;
        /// <summary>
        /// Is true if KEY does not exist
        /// </summary>
        public readonly ImmutableDictionary<string, string> KeyDoesNotExist;
        /// <summary>
        /// Is true if KEY exists
        /// </summary>
        public readonly string KeyExists;
        /// <summary>
        /// Is true if KEY exists and its value is not VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> KeyValueDoesNotEqual;
        /// <summary>
        /// Is true if key KEY exists and its value does not match VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> KeyValueDoesNotMatch;
        /// <summary>
        /// Is true if KEY exists and its value is VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> KeyValueEquals;
        /// <summary>
        /// Is true if key KEY exists and its value matches VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> KeyValueMatches;
        /// <summary>
        /// Is true if all keys matching KEY have values that do not match VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> MatchingKeysDoNotHaveMatchingValues;
        /// <summary>
        /// Is true if all keys matching KEY have values that match VALUE
        /// </summary>
        public readonly ImmutableDictionary<string, string> MatchingKeysHaveMatchingValues;
        /// <summary>
        /// Is true if no key matches regex KEY
        /// </summary>
        public readonly string NoKeyMatches;

        [OutputConstructor]
        private ClusterFilterSpecFiltersModifyConditions(
            string aKeyMatches,

            ImmutableDictionary<string, string> keyDoesNotExist,

            string keyExists,

            ImmutableDictionary<string, string> keyValueDoesNotEqual,

            ImmutableDictionary<string, string> keyValueDoesNotMatch,

            ImmutableDictionary<string, string> keyValueEquals,

            ImmutableDictionary<string, string> keyValueMatches,

            ImmutableDictionary<string, string> matchingKeysDoNotHaveMatchingValues,

            ImmutableDictionary<string, string> matchingKeysHaveMatchingValues,

            string noKeyMatches)
        {
            AKeyMatches = aKeyMatches;
            KeyDoesNotExist = keyDoesNotExist;
            KeyExists = keyExists;
            KeyValueDoesNotEqual = keyValueDoesNotEqual;
            KeyValueDoesNotMatch = keyValueDoesNotMatch;
            KeyValueEquals = keyValueEquals;
            KeyValueMatches = keyValueMatches;
            MatchingKeysDoNotHaveMatchingValues = matchingKeysDoNotHaveMatchingValues;
            MatchingKeysHaveMatchingValues = matchingKeysHaveMatchingValues;
            NoKeyMatches = noKeyMatches;
        }
    }
}
