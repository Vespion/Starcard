// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Traefik.V1Alpha1
{

    /// <summary>
    /// Headers holds the headers middleware configuration. This middleware manages the requests and responses headers. More info: https://doc.traefik.io/traefik/v2.9/middlewares/http/headers/#customrequestheaders
    /// </summary>
    public class MiddlewareSpecHeadersArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// AccessControlAllowCredentials defines whether the request can include user credentials.
        /// </summary>
        [Input("accessControlAllowCredentials")]
        public Input<bool>? AccessControlAllowCredentials { get; set; }

        [Input("accessControlAllowHeaders")]
        private InputList<string>? _accessControlAllowHeaders;

        /// <summary>
        /// AccessControlAllowHeaders defines the Access-Control-Request-Headers values sent in preflight response.
        /// </summary>
        public InputList<string> AccessControlAllowHeaders
        {
            get => _accessControlAllowHeaders ?? (_accessControlAllowHeaders = new InputList<string>());
            set => _accessControlAllowHeaders = value;
        }

        [Input("accessControlAllowMethods")]
        private InputList<string>? _accessControlAllowMethods;

        /// <summary>
        /// AccessControlAllowMethods defines the Access-Control-Request-Method values sent in preflight response.
        /// </summary>
        public InputList<string> AccessControlAllowMethods
        {
            get => _accessControlAllowMethods ?? (_accessControlAllowMethods = new InputList<string>());
            set => _accessControlAllowMethods = value;
        }

        [Input("accessControlAllowOriginList")]
        private InputList<string>? _accessControlAllowOriginList;

        /// <summary>
        /// AccessControlAllowOriginList is a list of allowable origins. Can also be a wildcard origin "*".
        /// </summary>
        public InputList<string> AccessControlAllowOriginList
        {
            get => _accessControlAllowOriginList ?? (_accessControlAllowOriginList = new InputList<string>());
            set => _accessControlAllowOriginList = value;
        }

        [Input("accessControlAllowOriginListRegex")]
        private InputList<string>? _accessControlAllowOriginListRegex;

        /// <summary>
        /// AccessControlAllowOriginListRegex is a list of allowable origins written following the Regular Expression syntax (https://golang.org/pkg/regexp/).
        /// </summary>
        public InputList<string> AccessControlAllowOriginListRegex
        {
            get => _accessControlAllowOriginListRegex ?? (_accessControlAllowOriginListRegex = new InputList<string>());
            set => _accessControlAllowOriginListRegex = value;
        }

        [Input("accessControlExposeHeaders")]
        private InputList<string>? _accessControlExposeHeaders;

        /// <summary>
        /// AccessControlExposeHeaders defines the Access-Control-Expose-Headers values sent in preflight response.
        /// </summary>
        public InputList<string> AccessControlExposeHeaders
        {
            get => _accessControlExposeHeaders ?? (_accessControlExposeHeaders = new InputList<string>());
            set => _accessControlExposeHeaders = value;
        }

        /// <summary>
        /// AccessControlMaxAge defines the time that a preflight request may be cached.
        /// </summary>
        [Input("accessControlMaxAge")]
        public Input<int>? AccessControlMaxAge { get; set; }

        /// <summary>
        /// AddVaryHeader defines whether the Vary header is automatically added/updated when the AccessControlAllowOriginList is set.
        /// </summary>
        [Input("addVaryHeader")]
        public Input<bool>? AddVaryHeader { get; set; }

        [Input("allowedHosts")]
        private InputList<string>? _allowedHosts;

        /// <summary>
        /// AllowedHosts defines the fully qualified list of allowed domain names.
        /// </summary>
        public InputList<string> AllowedHosts
        {
            get => _allowedHosts ?? (_allowedHosts = new InputList<string>());
            set => _allowedHosts = value;
        }

        /// <summary>
        /// BrowserXSSFilter defines whether to add the X-XSS-Protection header with the value 1; mode=block.
        /// </summary>
        [Input("browserXssFilter")]
        public Input<bool>? BrowserXssFilter { get; set; }

        /// <summary>
        /// ContentSecurityPolicy defines the Content-Security-Policy header value.
        /// </summary>
        [Input("contentSecurityPolicy")]
        public Input<string>? ContentSecurityPolicy { get; set; }

        /// <summary>
        /// ContentTypeNosniff defines whether to add the X-Content-Type-Options header with the nosniff value.
        /// </summary>
        [Input("contentTypeNosniff")]
        public Input<bool>? ContentTypeNosniff { get; set; }

        /// <summary>
        /// CustomBrowserXSSValue defines the X-XSS-Protection header value. This overrides the BrowserXssFilter option.
        /// </summary>
        [Input("customBrowserXSSValue")]
        public Input<string>? CustomBrowserXSSValue { get; set; }

        /// <summary>
        /// CustomFrameOptionsValue defines the X-Frame-Options header value. This overrides the FrameDeny option.
        /// </summary>
        [Input("customFrameOptionsValue")]
        public Input<string>? CustomFrameOptionsValue { get; set; }

        [Input("customRequestHeaders")]
        private InputMap<string>? _customRequestHeaders;

        /// <summary>
        /// CustomRequestHeaders defines the header names and values to apply to the request.
        /// </summary>
        public InputMap<string> CustomRequestHeaders
        {
            get => _customRequestHeaders ?? (_customRequestHeaders = new InputMap<string>());
            set => _customRequestHeaders = value;
        }

        [Input("customResponseHeaders")]
        private InputMap<string>? _customResponseHeaders;

        /// <summary>
        /// CustomResponseHeaders defines the header names and values to apply to the response.
        /// </summary>
        public InputMap<string> CustomResponseHeaders
        {
            get => _customResponseHeaders ?? (_customResponseHeaders = new InputMap<string>());
            set => _customResponseHeaders = value;
        }

        /// <summary>
        /// Deprecated: use PermissionsPolicy instead.
        /// </summary>
        [Input("featurePolicy")]
        public Input<string>? FeaturePolicy { get; set; }

        /// <summary>
        /// ForceSTSHeader defines whether to add the STS header even when the connection is HTTP.
        /// </summary>
        [Input("forceSTSHeader")]
        public Input<bool>? ForceSTSHeader { get; set; }

        /// <summary>
        /// FrameDeny defines whether to add the X-Frame-Options header with the DENY value.
        /// </summary>
        [Input("frameDeny")]
        public Input<bool>? FrameDeny { get; set; }

        [Input("hostsProxyHeaders")]
        private InputList<string>? _hostsProxyHeaders;

        /// <summary>
        /// HostsProxyHeaders defines the header keys that may hold a proxied hostname value for the request.
        /// </summary>
        public InputList<string> HostsProxyHeaders
        {
            get => _hostsProxyHeaders ?? (_hostsProxyHeaders = new InputList<string>());
            set => _hostsProxyHeaders = value;
        }

        /// <summary>
        /// IsDevelopment defines whether to mitigate the unwanted effects of the AllowedHosts, SSL, and STS options when developing. Usually testing takes place using HTTP, not HTTPS, and on localhost, not your production domain. If you would like your development environment to mimic production with complete Host blocking, SSL redirects, and STS headers, leave this as false.
        /// </summary>
        [Input("isDevelopment")]
        public Input<bool>? IsDevelopment { get; set; }

        /// <summary>
        /// PermissionsPolicy defines the Permissions-Policy header value. This allows sites to control browser features.
        /// </summary>
        [Input("permissionsPolicy")]
        public Input<string>? PermissionsPolicy { get; set; }

        /// <summary>
        /// PublicKey is the public key that implements HPKP to prevent MITM attacks with forged certificates.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        /// <summary>
        /// ReferrerPolicy defines the Referrer-Policy header value. This allows sites to control whether browsers forward the Referer header to other sites.
        /// </summary>
        [Input("referrerPolicy")]
        public Input<string>? ReferrerPolicy { get; set; }

        /// <summary>
        /// Deprecated: use RedirectRegex instead.
        /// </summary>
        [Input("sslForceHost")]
        public Input<bool>? SslForceHost { get; set; }

        /// <summary>
        /// Deprecated: use RedirectRegex instead.
        /// </summary>
        [Input("sslHost")]
        public Input<string>? SslHost { get; set; }

        [Input("sslProxyHeaders")]
        private InputMap<string>? _sslProxyHeaders;

        /// <summary>
        /// SSLProxyHeaders defines the header keys with associated values that would indicate a valid HTTPS request. It can be useful when using other proxies (example: "X-Forwarded-Proto": "https").
        /// </summary>
        public InputMap<string> SslProxyHeaders
        {
            get => _sslProxyHeaders ?? (_sslProxyHeaders = new InputMap<string>());
            set => _sslProxyHeaders = value;
        }

        /// <summary>
        /// Deprecated: use EntryPoint redirection or RedirectScheme instead.
        /// </summary>
        [Input("sslRedirect")]
        public Input<bool>? SslRedirect { get; set; }

        /// <summary>
        /// Deprecated: use EntryPoint redirection or RedirectScheme instead.
        /// </summary>
        [Input("sslTemporaryRedirect")]
        public Input<bool>? SslTemporaryRedirect { get; set; }

        /// <summary>
        /// STSIncludeSubdomains defines whether the includeSubDomains directive is appended to the Strict-Transport-Security header.
        /// </summary>
        [Input("stsIncludeSubdomains")]
        public Input<bool>? StsIncludeSubdomains { get; set; }

        /// <summary>
        /// STSPreload defines whether the preload flag is appended to the Strict-Transport-Security header.
        /// </summary>
        [Input("stsPreload")]
        public Input<bool>? StsPreload { get; set; }

        /// <summary>
        /// STSSeconds defines the max-age of the Strict-Transport-Security header. If set to 0, the header is not set.
        /// </summary>
        [Input("stsSeconds")]
        public Input<int>? StsSeconds { get; set; }

        public MiddlewareSpecHeadersArgs()
        {
        }
        public static new MiddlewareSpecHeadersArgs Empty => new MiddlewareSpecHeadersArgs();
    }
}
