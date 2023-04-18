// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1
{

    /// <summary>
    /// Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.
    /// </summary>
    [OutputType]
    public sealed class PoolerSpecTemplateSpecEphemeralcontainersSecuritycontext
    {
        /// <summary>
        /// AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly bool AllowPrivilegeEscalation;
        /// <summary>
        /// The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextCapabilities Capabilities;
        /// <summary>
        /// Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly bool Privileged;
        /// <summary>
        /// procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly string ProcMount;
        /// <summary>
        /// Whether this container has a read-only root filesystem. Default is false. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly bool ReadOnlyRootFilesystem;
        /// <summary>
        /// The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly int RunAsGroup;
        /// <summary>
        /// Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        public readonly bool RunAsNonRoot;
        /// <summary>
        /// The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly int RunAsUser;
        /// <summary>
        /// The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextSelinuxoptions SeLinuxOptions;
        /// <summary>
        /// The seccomp options to use by this container. If seccomp options are provided at both the pod &amp; container level, the container options override the pod options. Note that this field cannot be set when spec.os.name is windows.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextSeccompprofile SeccompProfile;
        /// <summary>
        /// The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence. Note that this field cannot be set when spec.os.name is linux.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextWindowsoptions WindowsOptions;

        [OutputConstructor]
        private PoolerSpecTemplateSpecEphemeralcontainersSecuritycontext(
            bool allowPrivilegeEscalation,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextCapabilities capabilities,

            bool privileged,

            string procMount,

            bool readOnlyRootFilesystem,

            int runAsGroup,

            bool runAsNonRoot,

            int runAsUser,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextSelinuxoptions seLinuxOptions,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextSeccompprofile seccompProfile,

            Pulumi.Kubernetes.Types.Outputs.Postgresql.V1.PoolerSpecTemplateSpecEphemeralcontainersSecuritycontextWindowsoptions windowsOptions)
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            Privileged = privileged;
            ProcMount = procMount;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RunAsGroup = runAsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            SeccompProfile = seccompProfile;
            WindowsOptions = windowsOptions;
        }
    }
}
