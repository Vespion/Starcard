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
    /// An EphemeralContainer is a temporary container that you may add to an existing Pod for user-initiated activities such as debugging. Ephemeral containers have no resource or scheduling guarantees, and they will not be restarted when they exit or when a Pod is removed or restarted. The kubelet may evict a Pod if an ephemeral container causes the Pod to exceed its resource allocation. 
    ///  To add an ephemeral container, use the ephemeralcontainers subresource of an existing Pod. Ephemeral containers may not be removed or restarted.
    /// </summary>
    public class PoolerSpecTemplateSpecEphemeralcontainersArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Arguments to the entrypoint. The image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("command")]
        private InputList<string>? _command;

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public InputList<string> Command
        {
            get => _command ?? (_command = new InputList<string>());
            set => _command = value;
        }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvArgs>? _env;

        /// <summary>
        /// List of environment variables to set in the container. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvArgs>());
            set => _env = value;
        }

        [Input("envFrom")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvfromArgs>? _envFrom;

        /// <summary>
        /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvfromArgs> EnvFrom
        {
            get => _envFrom ?? (_envFrom = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersEnvfromArgs>());
            set => _envFrom = value;
        }

        /// <summary>
        /// Container image name. More info: https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// </summary>
        [Input("imagePullPolicy")]
        public Input<string>? ImagePullPolicy { get; set; }

        /// <summary>
        /// Lifecycle is not allowed for ephemeral containers.
        /// </summary>
        [Input("lifecycle")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersLifecycleArgs>? Lifecycle { get; set; }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [Input("livenessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersLivenessprobeArgs>? LivenessProbe { get; set; }

        /// <summary>
        /// Name of the ephemeral container specified as a DNS_LABEL. This name must be unique among all containers, init containers and ephemeral containers.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersPortsArgs>? _ports;

        /// <summary>
        /// Ports are not allowed for ephemeral containers.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersPortsArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersPortsArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [Input("readinessProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersReadinessprobeArgs>? ReadinessProbe { get; set; }

        /// <summary>
        /// Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.
        /// </summary>
        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersResourcesArgs>? Resources { get; set; }

        /// <summary>
        /// Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextArgs>? SecurityContext { get; set; }

        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        [Input("startupProbe")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersStartupprobeArgs>? StartupProbe { get; set; }

        /// <summary>
        /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        /// </summary>
        [Input("stdin")]
        public Input<bool>? Stdin { get; set; }

        /// <summary>
        /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        /// </summary>
        [Input("stdinOnce")]
        public Input<bool>? StdinOnce { get; set; }

        /// <summary>
        /// If set, the name of the container from PodSpec that this ephemeral container targets. The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container uses the namespaces configured in the Pod spec. 
        ///  The container runtime must implement support for this feature. If the runtime does not support namespace targeting then the result of setting this field is undefined.
        /// </summary>
        [Input("targetContainerName")]
        public Input<string>? TargetContainerName { get; set; }

        /// <summary>
        /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        /// </summary>
        [Input("terminationMessagePath")]
        public Input<string>? TerminationMessagePath { get; set; }

        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [Input("terminationMessagePolicy")]
        public Input<string>? TerminationMessagePolicy { get; set; }

        /// <summary>
        /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
        /// </summary>
        [Input("tty")]
        public Input<bool>? Tty { get; set; }

        [Input("volumeDevices")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumedevicesArgs>? _volumeDevices;

        /// <summary>
        /// volumeDevices is the list of block devices to be used by the container.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumedevicesArgs> VolumeDevices
        {
            get => _volumeDevices ?? (_volumeDevices = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumedevicesArgs>());
            set => _volumeDevices = value;
        }

        [Input("volumeMounts")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumemountsArgs>? _volumeMounts;

        /// <summary>
        /// Pod volumes to mount into the container's filesystem. Subpath mounts are not allowed for ephemeral containers. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumemountsArgs> VolumeMounts
        {
            get => _volumeMounts ?? (_volumeMounts = new InputList<Pulumi.Kubernetes.Types.Inputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersVolumemountsArgs>());
            set => _volumeMounts = value;
        }

        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
        /// </summary>
        [Input("workingDir")]
        public Input<string>? WorkingDir { get; set; }

        public PoolerSpecTemplateSpecEphemeralcontainersArgs()
        {
        }
        public static new PoolerSpecTemplateSpecEphemeralcontainersArgs Empty => new PoolerSpecTemplateSpecEphemeralcontainersArgs();
    }
}
