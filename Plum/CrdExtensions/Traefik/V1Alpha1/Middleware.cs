// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Crds.Traefik.V1Alpha1
{
    /// <summary>
    /// Middleware is the CRD implementation of a Traefik Middleware. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/overview/
    /// </summary>
    [CrdsResourceType("kubernetes:traefik.containo.us/v1alpha1:Middleware")]
    public partial class Middleware : KubernetesResource
    {
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// MiddlewareSpec defines the desired state of a Middleware.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Traefik.V1Alpha1.MiddlewareSpec> Spec { get; private set; } = null!;


        /// <summary>
        /// Create a Middleware resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Middleware(string name, Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:Middleware", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Middleware(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:Middleware", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Middleware(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:traefik.containo.us/v1alpha1:Middleware", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareArgs();
            args.ApiVersion = "traefik.containo.us/v1alpha1";
            args.Kind = "Middleware";
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
        /// Get an existing Middleware resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Middleware Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Middleware(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    public class MiddlewareArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// MiddlewareSpec defines the desired state of a Middleware.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1.MiddlewareSpecArgs>? Spec { get; set; }

        public MiddlewareArgs()
        {
        }
        public static new MiddlewareArgs Empty => new MiddlewareArgs();
    }
}
