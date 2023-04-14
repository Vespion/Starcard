// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1
{

    /// <summary>
    /// CircuitBreaker holds the circuit breaker configuration.
    /// </summary>
    [OutputType]
    public sealed class MiddlewareSpecCircuitbreaker
    {
        /// <summary>
        /// CheckPeriod is the interval between successive checks of the circuit breaker condition (when in standby state).
        /// </summary>
        public readonly Union<int, string> CheckPeriod;
        /// <summary>
        /// Expression is the condition that triggers the tripped state.
        /// </summary>
        public readonly string Expression;
        /// <summary>
        /// FallbackDuration is the duration for which the circuit breaker will wait before trying to recover (from a tripped state).
        /// </summary>
        public readonly Union<int, string> FallbackDuration;
        /// <summary>
        /// RecoveryDuration is the duration for which the circuit breaker will try to recover (as soon as it is in recovering state).
        /// </summary>
        public readonly Union<int, string> RecoveryDuration;

        [OutputConstructor]
        private MiddlewareSpecCircuitbreaker(
            Union<int, string> checkPeriod,

            string expression,

            Union<int, string> fallbackDuration,

            Union<int, string> recoveryDuration)
        {
            CheckPeriod = checkPeriod;
            Expression = expression;
            FallbackDuration = fallbackDuration;
            RecoveryDuration = recoveryDuration;
        }
    }
}
