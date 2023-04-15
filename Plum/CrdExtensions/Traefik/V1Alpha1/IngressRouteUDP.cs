// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Crds.Traefik.V1Alpha1
{
    /// <summary>
    /// IngressRouteUDP is a CRD implementation of a Traefik UDP Router.
    /// </summary>
    [CrdsResourceType("kubernetes:traefik.containo.us/v1alpha1:IngressRouteUDP")]
    public partial class IngressRouteUDP : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// IngressRouteUDPSpec defines the desired state of a IngressRouteUDP.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.IngressRouteUDPSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a IngressRouteUDP resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IngressRouteUDP(string name, Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.IngressRouteUDPArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:IngressRouteUDP", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal IngressRouteUDP(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:IngressRouteUDP", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private IngressRouteUDP(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:IngressRouteUDP", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.IngressRouteUDPArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.IngressRouteUDPArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.IngressRouteUDPArgs();
            args.ApiVersion = "traefik.containo.us/v1alpha1";
            args.Kind = "IngressRouteUDP";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IngressRouteUDP resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IngressRouteUDP Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IngressRouteUDP(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    public class IngressRouteUDPArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// IngressRouteUDPSpec defines the desired state of a IngressRouteUDP.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.IngressRouteUDPSpecArgs>? Spec { get; set; }

        public IngressRouteUDPArgs()
        {
        }
        public static new IngressRouteUDPArgs Empty => new IngressRouteUDPArgs();
    }
}
