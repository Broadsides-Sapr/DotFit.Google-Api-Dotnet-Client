// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Firebaseappcheck.v1beta
{
    /// <summary>The Firebaseappcheck Service.</summary>
    public class FirebaseappcheckService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseappcheckService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseappcheckService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Jwks = new JwksResource(this);
            OauthClients = new OauthClientsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebaseappcheck";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://firebaseappcheck.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://firebaseappcheck.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase App Check API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase App Check API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Gets the Jwks resource.</summary>
        public virtual JwksResource Jwks { get; }

        /// <summary>Gets the OauthClients resource.</summary>
        public virtual OauthClientsResource OauthClients { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Firebaseappcheck requests.</summary>
    public abstract class FirebaseappcheckBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseappcheckBaseServiceRequest instance.</summary>
        protected FirebaseappcheckBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Firebaseappcheck parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "jwks" collection of methods.</summary>
    public class JwksResource
    {
        private const string Resource = "jwks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public JwksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns a public JWK set as specified by [RFC 7517](https://tools.ietf.org/html/rfc7517) that can be used to
        /// verify App Check tokens. Exactly one of the public keys in the returned set will successfully validate any
        /// App Check token that is currently valid.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name to the public JWK set. Must always be exactly the string `jwks`.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Returns a public JWK set as specified by [RFC 7517](https://tools.ietf.org/html/rfc7517) that can be used to
        /// verify App Check tokens. Exactly one of the public keys in the returned set will successfully validate any
        /// App Check token that is currently valid.
        /// </summary>
        public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPublicJwkSet>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative resource name to the public JWK set. Must always be exactly the string `jwks`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^jwks$",
                });
            }
        }
    }

    /// <summary>The "oauthClients" collection of methods.</summary>
    public class OauthClientsResource
    {
        private const string Resource = "oauthClients";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OauthClientsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Accepts an App Attest assertion and an artifact previously obtained from ExchangeAppAttestAttestation and
        /// verifies those with Apple. If valid, returns an AppCheckToken.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="app">
        /// Required. The relative resource name of the iOS app, in the format: ```
        /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced with
        /// the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
        /// 2510](https://google.aip.dev/cloud/2510) standard.
        /// </param>
        public virtual ExchangeAppAttestAssertionRequest ExchangeAppAttestAssertion(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest body, string app)
        {
            return new ExchangeAppAttestAssertionRequest(service, body, app);
        }

        /// <summary>
        /// Accepts an App Attest assertion and an artifact previously obtained from ExchangeAppAttestAttestation and
        /// verifies those with Apple. If valid, returns an AppCheckToken.
        /// </summary>
        public class ExchangeAppAttestAssertionRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
        {
            /// <summary>Constructs a new ExchangeAppAttestAssertion request.</summary>
            public ExchangeAppAttestAssertionRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest body, string app) : base(service)
            {
                App = app;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string App { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "exchangeAppAttestAssertion";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+app}:exchangeAppAttestAssertion";

            /// <summary>Initializes ExchangeAppAttestAssertion parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                {
                    Name = "app",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^oauthClients/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Accepts an App Attest CBOR attestation and verifies it with Apple using your preconfigured team and bundle
        /// IDs. If valid, returns an attestation artifact that can later be exchanged for an AppCheckToken using
        /// ExchangeAppAttestAssertion. For convenience and performance, this method's response object will also contain
        /// an AppCheckToken (if the verification is successful).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="app">
        /// Required. The relative resource name of the iOS app, in the format: ```
        /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced with
        /// the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
        /// 2510](https://google.aip.dev/cloud/2510) standard.
        /// </param>
        public virtual ExchangeAppAttestAttestationRequest ExchangeAppAttestAttestation(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest body, string app)
        {
            return new ExchangeAppAttestAttestationRequest(service, body, app);
        }

        /// <summary>
        /// Accepts an App Attest CBOR attestation and verifies it with Apple using your preconfigured team and bundle
        /// IDs. If valid, returns an attestation artifact that can later be exchanged for an AppCheckToken using
        /// ExchangeAppAttestAssertion. For convenience and performance, this method's response object will also contain
        /// an AppCheckToken (if the verification is successful).
        /// </summary>
        public class ExchangeAppAttestAttestationRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationResponse>
        {
            /// <summary>Constructs a new ExchangeAppAttestAttestation request.</summary>
            public ExchangeAppAttestAttestationRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest body, string app) : base(service)
            {
                App = app;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string App { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "exchangeAppAttestAttestation";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+app}:exchangeAppAttestAttestation";

            /// <summary>Initializes ExchangeAppAttestAttestation parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                {
                    Name = "app",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^oauthClients/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Generates a challenge that protects the integrity of an immediately following call to
        /// ExchangeAppAttestAttestation or ExchangeAppAttestAssertion. A challenge should not be reused for multiple
        /// calls.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="app">
        /// Required. The relative resource name of the iOS app, in the format: ```
        /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced with
        /// the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
        /// 2510](https://google.aip.dev/cloud/2510) standard.
        /// </param>
        public virtual GenerateAppAttestChallengeRequest GenerateAppAttestChallenge(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest body, string app)
        {
            return new GenerateAppAttestChallengeRequest(service, body, app);
        }

        /// <summary>
        /// Generates a challenge that protects the integrity of an immediately following call to
        /// ExchangeAppAttestAttestation or ExchangeAppAttestAssertion. A challenge should not be reused for multiple
        /// calls.
        /// </summary>
        public class GenerateAppAttestChallengeRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeResponse>
        {
            /// <summary>Constructs a new GenerateAppAttestChallenge request.</summary>
            public GenerateAppAttestChallengeRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest body, string app) : base(service)
            {
                App = app;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string App { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generateAppAttestChallenge";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+app}:generateAppAttestChallenge";

            /// <summary>Initializes GenerateAppAttestChallenge parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                {
                    Name = "app",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^oauthClients/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apps = new AppsResource(service);
            Services = new ServicesResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                AppAttestConfig = new AppAttestConfigResource(service);
                DebugTokens = new DebugTokensResource(service);
                DeviceCheckConfig = new DeviceCheckConfigResource(service);
                PlayIntegrityConfig = new PlayIntegrityConfigResource(service);
                RecaptchaConfig = new RecaptchaConfigResource(service);
                RecaptchaEnterpriseConfig = new RecaptchaEnterpriseConfigResource(service);
                RecaptchaV3Config = new RecaptchaV3ConfigResource(service);
                SafetyNetConfig = new SafetyNetConfigResource(service);
            }

            /// <summary>Gets the AppAttestConfig resource.</summary>
            public virtual AppAttestConfigResource AppAttestConfig { get; }

            /// <summary>The "appAttestConfig" collection of methods.</summary>
            public class AppAttestConfigResource
            {
                private const string Resource = "appAttestConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AppAttestConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Atomically gets the AppAttestConfigs for the specified list of apps.</summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all AppAttestConfigs being retrieved, in the format ```
                /// projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>Atomically gets the AppAttestConfigs for the specified list of apps.</summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetAppAttestConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all AppAttestConfigs being retrieved, in the format
                    /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource
                    /// being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the AppAttestConfigs to retrieve, in the format ```
                    /// projects/{project_number}/apps/{app_id}/appAttestConfig ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/appAttestConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the AppAttestConfig for the specified app.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the AppAttestConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/appAttestConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the AppAttestConfig for the specified app.</summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppAttestConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the AppAttestConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/appAttestConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/appAttestConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the AppAttestConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange AppAttest tokens for App Check tokens.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the App Attest configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/appAttestConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppAttestConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the AppAttestConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange AppAttest tokens for App Check tokens.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppAttestConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppAttestConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the App Attest configuration object, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/appAttestConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the AppAttestConfig Gets to update.
                    /// Example: `token_ttl`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppAttestConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/appAttestConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the DebugTokens resource.</summary>
            public virtual DebugTokensResource DebugTokens { get; }

            /// <summary>The "debugTokens" collection of methods.</summary>
            public class DebugTokensResource
            {
                private const string Resource = "debugTokens";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DebugTokensResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a new DebugToken for the specified app. For security reasons, after the creation operation
                /// completes, the `token` field cannot be updated or retrieved, but you can revoke the debug token
                /// using DeleteDebugToken. Each app can have a maximum of 20 debug tokens.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The relative resource name of the parent app in which the specified DebugToken will be
                /// created, in the format: ``` projects/{project_number}/apps/{app_id} ```
                /// </param>
                public virtual CreateRequest Create(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new DebugToken for the specified app. For security reasons, after the creation operation
                /// completes, the `token` field cannot be updated or retrieved, but you can revoke the debug token
                /// using DeleteDebugToken. Each app can have a maximum of 20 debug tokens.
                /// </summary>
                public class CreateRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the parent app in which the specified DebugToken will be
                    /// created, in the format: ``` projects/{project_number}/apps/{app_id} ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/debugTokens";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified DebugToken. A deleted debug token cannot be used to exchange for an App Check
                /// token. Use this method when you suspect the secret `token` has been compromised or when you no
                /// longer need the debug token.
                /// </summary>
                /// <param name="name">
                /// Required. The relative resource name of the DebugToken to delete, in the format: ```
                /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified DebugToken. A deleted debug token cannot be used to exchange for an App Check
                /// token. Use this method when you suspect the secret `token` has been compromised or when you no
                /// longer need the debug token.
                /// </summary>
                public class DeleteRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the DebugToken to delete, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/debugTokens/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the specified DebugToken. For security reasons, the `token` field is never populated in the
                /// response.
                /// </summary>
                /// <param name="name">
                /// Required. The relative resource name of the debug token, in the format: ```
                /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the specified DebugToken. For security reasons, the `token` field is never populated in the
                /// response.
                /// </summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the debug token, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/debugTokens/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists all DebugTokens for the specified app. For security reasons, the `token` field is never
                /// populated in the response.
                /// </summary>
                /// <param name="parent">
                /// Required. The relative resource name of the parent app for which to list each associated DebugToken,
                /// in the format: ``` projects/{project_number}/apps/{app_id} ```
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists all DebugTokens for the specified app. For security reasons, the `token` field is never
                /// populated in the response.
                /// </summary>
                public class ListRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaListDebugTokensResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the parent app for which to list each associated
                    /// DebugToken, in the format: ``` projects/{project_number}/apps/{app_id} ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of DebugTokens to return in the response. Note that an app can have at most
                    /// 20 debug tokens. The server may return fewer than this at its own discretion. If no value is
                    /// specified (or too large a value is specified), the server will impose its own limit.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Token returned from a previous call to ListDebugTokens indicating where in the set of
                    /// DebugTokens to resume listing. Provide this to retrieve the subsequent page. When paginating,
                    /// all other parameters provided to ListDebugTokens must match the call that provided the page
                    /// token; if they do not match, the result is undefined.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/debugTokens";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates the specified DebugToken. For security reasons, the `token` field cannot be updated, nor
                /// will it be populated in the response, but you can revoke the debug token using DeleteDebugToken.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the debug token, in the format: ```
                /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the specified DebugToken. For security reasons, the `token` field cannot be updated, nor
                /// will it be populated in the response, but you can revoke the debug token using DeleteDebugToken.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the debug token, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the DebugToken to update. Example:
                    /// `display_name`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDebugToken Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/debugTokens/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the DeviceCheckConfig resource.</summary>
            public virtual DeviceCheckConfigResource DeviceCheckConfig { get; }

            /// <summary>The "deviceCheckConfig" collection of methods.</summary>
            public class DeviceCheckConfigResource
            {
                private const string Resource = "deviceCheckConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeviceCheckConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Atomically gets the DeviceCheckConfigs for the specified list of apps. For security reasons, the
                /// `private_key` field is never populated in the response.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all DeviceCheckConfigs being retrieved, in the format
                /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>
                /// Atomically gets the DeviceCheckConfigs for the specified list of apps. For security reasons, the
                /// `private_key` field is never populated in the response.
                /// </summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetDeviceCheckConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all DeviceCheckConfigs being retrieved, in the
                    /// format ``` projects/{project_number} ``` The parent collection in the `name` field of any
                    /// resource being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the DeviceCheckConfigs to retrieve, in the format ```
                    /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/deviceCheckConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the DeviceCheckConfig for the specified app. For security reasons, the `private_key` field is
                /// never populated in the response.
                /// </summary>
                /// <param name="name">
                /// Required. The relative resource name of the DeviceCheckConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the DeviceCheckConfig for the specified app. For security reasons, the `private_key` field is
                /// never populated in the response.
                /// </summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDeviceCheckConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the DeviceCheckConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/deviceCheckConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the DeviceCheckConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange DeviceCheck tokens for App Check tokens. For security
                /// reasons, the `private_key` field is never populated in the response.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the DeviceCheck configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDeviceCheckConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the DeviceCheckConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange DeviceCheck tokens for App Check tokens. For security
                /// reasons, the `private_key` field is never populated in the response.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDeviceCheckConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDeviceCheckConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the DeviceCheck configuration object, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the DeviceCheckConfig Gets to update.
                    /// Example: `key_id,private_key`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaDeviceCheckConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/deviceCheckConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the PlayIntegrityConfig resource.</summary>
            public virtual PlayIntegrityConfigResource PlayIntegrityConfig { get; }

            /// <summary>The "playIntegrityConfig" collection of methods.</summary>
            public class PlayIntegrityConfigResource
            {
                private const string Resource = "playIntegrityConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PlayIntegrityConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Atomically gets the PlayIntegrityConfigs for the specified list of apps.</summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all PlayIntegrityConfigs being retrieved, in the format
                /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>Atomically gets the PlayIntegrityConfigs for the specified list of apps.</summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetPlayIntegrityConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all PlayIntegrityConfigs being retrieved, in the
                    /// format ``` projects/{project_number} ``` The parent collection in the `name` field of any
                    /// resource being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the PlayIntegrityConfigs to retrieve, in the format ```
                    /// projects/{project_number}/apps/{app_id}/playIntegrityConfig ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/playIntegrityConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the PlayIntegrityConfig for the specified app.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the PlayIntegrityConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/playIntegrityConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the PlayIntegrityConfig for the specified app.</summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPlayIntegrityConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the PlayIntegrityConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/playIntegrityConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/playIntegrityConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the PlayIntegrityConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange Play Integrity tokens for App Check tokens.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the Play Integrity configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/playIntegrityConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPlayIntegrityConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the PlayIntegrityConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange Play Integrity tokens for App Check tokens.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPlayIntegrityConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPlayIntegrityConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the Play Integrity configuration object, in the format:
                    /// ``` projects/{project_number}/apps/{app_id}/playIntegrityConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the PlayIntegrityConfig Gets to update.
                    /// Example: `token_ttl`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaPlayIntegrityConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/playIntegrityConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the RecaptchaConfig resource.</summary>
            public virtual RecaptchaConfigResource RecaptchaConfig { get; }

            /// <summary>The "recaptchaConfig" collection of methods.</summary>
            public class RecaptchaConfigResource
            {
                private const string Resource = "recaptchaConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecaptchaConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Atomically gets the RecaptchaConfigs for the specified list of apps. For security reasons, the
                /// `site_secret` field is never populated in the response.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all RecaptchaConfigs being retrieved, in the format ```
                /// projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>
                /// Atomically gets the RecaptchaConfigs for the specified list of apps. For security reasons, the
                /// `site_secret` field is never populated in the response.
                /// </summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetRecaptchaConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all RecaptchaConfigs being retrieved, in the format
                    /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource
                    /// being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the RecaptchaConfigs to retrieve, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/recaptchaConfig ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/recaptchaConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the RecaptchaConfig for the specified app. For security reasons, the `site_secret` field is
                /// never populated in the response.
                /// </summary>
                /// <param name="name">
                /// Required. The relative resource name of the RecaptchaConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/recaptchaConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the RecaptchaConfig for the specified app. For security reasons, the `site_secret` field is
                /// never populated in the response.
                /// </summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the RecaptchaConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/recaptchaConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the RecaptchaConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange reCAPTCHA tokens for App Check tokens. For security
                /// reasons, the `site_secret` field is never populated in the response.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/recaptchaConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the RecaptchaConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange reCAPTCHA tokens for App Check tokens. For security
                /// reasons, the `site_secret` field is never populated in the response.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format:
                    /// ``` projects/{project_number}/apps/{app_id}/recaptchaConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the RecaptchaConfig to update. Example:
                    /// `site_secret`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the RecaptchaEnterpriseConfig resource.</summary>
            public virtual RecaptchaEnterpriseConfigResource RecaptchaEnterpriseConfig { get; }

            /// <summary>The "recaptchaEnterpriseConfig" collection of methods.</summary>
            public class RecaptchaEnterpriseConfigResource
            {
                private const string Resource = "recaptchaEnterpriseConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecaptchaEnterpriseConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Atomically gets the RecaptchaEnterpriseConfigs for the specified list of apps.</summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all RecaptchaEnterpriseConfigs being retrieved, in the
                /// format ``` projects/{project_number} ``` The parent collection in the `name` field of any resource
                /// being retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>Atomically gets the RecaptchaEnterpriseConfigs for the specified list of apps.</summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetRecaptchaEnterpriseConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all RecaptchaEnterpriseConfigs being retrieved, in
                    /// the format ``` projects/{project_number} ``` The parent collection in the `name` field of any
                    /// resource being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the RecaptchaEnterpriseConfigs to retrieve, in the
                    /// format: ``` projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ``` A maximum of
                    /// 100 objects can be retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/recaptchaEnterpriseConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the RecaptchaEnterpriseConfig for the specified app.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the RecaptchaEnterpriseConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the RecaptchaEnterpriseConfig for the specified app.</summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the RecaptchaEnterpriseConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaEnterpriseConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the RecaptchaEnterpriseConfig for the specified app. While this configuration is incomplete
                /// or invalid, the app will be unable to exchange reCAPTCHA Enterprise tokens for App Check tokens.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the reCAPTCHA Enterprise configuration object, in the
                /// format: ``` projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the RecaptchaEnterpriseConfig for the specified app. While this configuration is incomplete
                /// or invalid, the app will be unable to exchange reCAPTCHA Enterprise tokens for App Check tokens.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the reCAPTCHA Enterprise configuration object, in the
                    /// format: ``` projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the RecaptchaEnterpriseConfig to update.
                    /// Example: `site_key`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaEnterpriseConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the RecaptchaV3Config resource.</summary>
            public virtual RecaptchaV3ConfigResource RecaptchaV3Config { get; }

            /// <summary>The "recaptchaV3Config" collection of methods.</summary>
            public class RecaptchaV3ConfigResource
            {
                private const string Resource = "recaptchaV3Config";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RecaptchaV3ConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Atomically gets the RecaptchaV3Configs for the specified list of apps. For security reasons, the
                /// `site_secret` field is never populated in the response.
                /// </summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all RecaptchaV3Configs being retrieved, in the format
                /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>
                /// Atomically gets the RecaptchaV3Configs for the specified list of apps. For security reasons, the
                /// `site_secret` field is never populated in the response.
                /// </summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetRecaptchaV3ConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all RecaptchaV3Configs being retrieved, in the
                    /// format ``` projects/{project_number} ``` The parent collection in the `name` field of any
                    /// resource being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the RecaptchaV3Configs to retrieve, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/recaptchaV3Config ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/recaptchaV3Config:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Gets the RecaptchaV3Config for the specified app. For security reasons, the `site_secret` field is
                /// never populated in the response.
                /// </summary>
                /// <param name="name">
                /// Required. The relative resource name of the RecaptchaV3Config, in the format: ```
                /// projects/{project_number}/apps/{app_id}/recaptchaV3Config ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the RecaptchaV3Config for the specified app. For security reasons, the `site_secret` field is
                /// never populated in the response.
                /// </summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaV3Config>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the RecaptchaV3Config, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/recaptchaV3Config ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaV3Config$",
                        });
                    }
                }

                /// <summary>
                /// Updates the RecaptchaV3Config for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange reCAPTCHA V3 tokens for App Check tokens. For security
                /// reasons, the `site_secret` field is never populated in the response.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/recaptchaV3Config ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaV3Config body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the RecaptchaV3Config for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange reCAPTCHA V3 tokens for App Check tokens. For security
                /// reasons, the `site_secret` field is never populated in the response.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaV3Config>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaV3Config body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format:
                    /// ``` projects/{project_number}/apps/{app_id}/recaptchaV3Config ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the RecaptchaV3Config to update. Example:
                    /// `site_secret`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaRecaptchaV3Config Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/recaptchaV3Config$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the SafetyNetConfig resource.</summary>
            public virtual SafetyNetConfigResource SafetyNetConfig { get; }

            /// <summary>The "safetyNetConfig" collection of methods.</summary>
            public class SafetyNetConfigResource
            {
                private const string Resource = "safetyNetConfig";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SafetyNetConfigResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Atomically gets the SafetyNetConfigs for the specified list of apps.</summary>
                /// <param name="parent">
                /// Required. The parent project name shared by all SafetyNetConfigs being retrieved, in the format ```
                /// projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// retrieved must match this field, or the entire batch fails.
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(service, parent);
                }

                /// <summary>Atomically gets the SafetyNetConfigs for the specified list of apps.</summary>
                public class BatchGetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchGetSafetyNetConfigsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent project name shared by all SafetyNetConfigs being retrieved, in the format
                    /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource
                    /// being retrieved must match this field, or the entire batch fails.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The relative resource names of the SafetyNetConfigs to retrieve, in the format ```
                    /// projects/{project_number}/apps/{app_id}/safetyNetConfig ``` A maximum of 100 objects can be
                    /// retrieved in a batch.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+parent}/apps/-/safetyNetConfig:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Gets the SafetyNetConfig for the specified app.</summary>
                /// <param name="name">
                /// Required. The relative resource name of the SafetyNetConfig, in the format: ```
                /// projects/{project_number}/apps/{app_id}/safetyNetConfig ```
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the SafetyNetConfig for the specified app.</summary>
                public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaSafetyNetConfig>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the SafetyNetConfig, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/safetyNetConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/safetyNetConfig$",
                        });
                    }
                }

                /// <summary>
                /// Updates the SafetyNetConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange SafetyNet tokens for App Check tokens.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The relative resource name of the SafetyNet configuration object, in the format: ```
                /// projects/{project_number}/apps/{app_id}/safetyNetConfig ```
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaSafetyNetConfig body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the SafetyNetConfig for the specified app. While this configuration is incomplete or
                /// invalid, the app will be unable to exchange SafetyNet tokens for App Check tokens.
                /// </summary>
                public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaSafetyNetConfig>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaSafetyNetConfig body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The relative resource name of the SafetyNet configuration object, in the format: ```
                    /// projects/{project_number}/apps/{app_id}/safetyNetConfig ```
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. A comma-separated list of names of fields in the SafetyNetConfig Gets to update.
                    /// Example: `token_ttl`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaSafetyNetConfig Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/safetyNetConfig$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Accepts an App Attest assertion and an artifact previously obtained from ExchangeAppAttestAttestation
            /// and verifies those with Apple. If valid, returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeAppAttestAssertionRequest ExchangeAppAttestAssertion(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest body, string app)
            {
                return new ExchangeAppAttestAssertionRequest(service, body, app);
            }

            /// <summary>
            /// Accepts an App Attest assertion and an artifact previously obtained from ExchangeAppAttestAttestation
            /// and verifies those with Apple. If valid, returns an AppCheckToken.
            /// </summary>
            public class ExchangeAppAttestAssertionRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeAppAttestAssertion request.</summary>
                public ExchangeAppAttestAssertionRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the iOS app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeAppAttestAssertion";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeAppAttestAssertion";

                /// <summary>Initializes ExchangeAppAttestAssertion parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Accepts an App Attest CBOR attestation and verifies it with Apple using your preconfigured team and
            /// bundle IDs. If valid, returns an attestation artifact that can later be exchanged for an AppCheckToken
            /// using ExchangeAppAttestAssertion. For convenience and performance, this method's response object will
            /// also contain an AppCheckToken (if the verification is successful).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeAppAttestAttestationRequest ExchangeAppAttestAttestation(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest body, string app)
            {
                return new ExchangeAppAttestAttestationRequest(service, body, app);
            }

            /// <summary>
            /// Accepts an App Attest CBOR attestation and verifies it with Apple using your preconfigured team and
            /// bundle IDs. If valid, returns an attestation artifact that can later be exchanged for an AppCheckToken
            /// using ExchangeAppAttestAssertion. For convenience and performance, this method's response object will
            /// also contain an AppCheckToken (if the verification is successful).
            /// </summary>
            public class ExchangeAppAttestAttestationRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationResponse>
            {
                /// <summary>Constructs a new ExchangeAppAttestAttestation request.</summary>
                public ExchangeAppAttestAttestationRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the iOS app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeAppAttestAttestation";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeAppAttestAttestation";

                /// <summary>Initializes ExchangeAppAttestAttestation parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a custom token signed using your project's Admin SDK service account credentials. If valid,
            /// returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeCustomTokenRequest ExchangeCustomToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeCustomTokenRequest body, string app)
            {
                return new ExchangeCustomTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a custom token signed using your project's Admin SDK service account credentials. If valid,
            /// returns an AppCheckToken.
            /// </summary>
            public class ExchangeCustomTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeCustomToken request.</summary>
                public ExchangeCustomTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeCustomTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeCustomTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeCustomToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeCustomToken";

                /// <summary>Initializes ExchangeCustomToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a debug token secret that you have previously created using CreateDebugToken. If valid,
            /// returns an AppCheckToken. Note that a restrictive quota is enforced on this method to prevent accidental
            /// exposure of the app to abuse.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeDebugTokenRequest ExchangeDebugToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDebugTokenRequest body, string app)
            {
                return new ExchangeDebugTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a debug token secret that you have previously created using CreateDebugToken. If valid,
            /// returns an AppCheckToken. Note that a restrictive quota is enforced on this method to prevent accidental
            /// exposure of the app to abuse.
            /// </summary>
            public class ExchangeDebugTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeDebugToken request.</summary>
                public ExchangeDebugTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDebugTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDebugTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeDebugToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeDebugToken";

                /// <summary>Initializes ExchangeDebugToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Accepts a [`device_token`](https://developer.apple.com/documentation/devicecheck/dcdevice) issued by
            /// DeviceCheck, and attempts to validate it with Apple. If valid, returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeDeviceCheckTokenRequest ExchangeDeviceCheckToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDeviceCheckTokenRequest body, string app)
            {
                return new ExchangeDeviceCheckTokenRequest(service, body, app);
            }

            /// <summary>
            /// Accepts a [`device_token`](https://developer.apple.com/documentation/devicecheck/dcdevice) issued by
            /// DeviceCheck, and attempts to validate it with Apple. If valid, returns an AppCheckToken.
            /// </summary>
            public class ExchangeDeviceCheckTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeDeviceCheckToken request.</summary>
                public ExchangeDeviceCheckTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDeviceCheckTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the iOS app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeDeviceCheckTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeDeviceCheckToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeDeviceCheckToken";

                /// <summary>Initializes ExchangeDeviceCheckToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates an [integrity verdict response token from Play
            /// Integrity](https://developer.android.com/google/play/integrity/verdict#decrypt-verify). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the Android app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangePlayIntegrityTokenRequest ExchangePlayIntegrityToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangePlayIntegrityTokenRequest body, string app)
            {
                return new ExchangePlayIntegrityTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates an [integrity verdict response token from Play
            /// Integrity](https://developer.android.com/google/play/integrity/verdict#decrypt-verify). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            public class ExchangePlayIntegrityTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangePlayIntegrityToken request.</summary>
                public ExchangePlayIntegrityTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangePlayIntegrityTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the Android app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangePlayIntegrityTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangePlayIntegrityToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangePlayIntegrityToken";

                /// <summary>Initializes ExchangePlayIntegrityToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a [reCAPTCHA Enterprise response
            /// token](https://cloud.google.com/recaptcha-enterprise/docs/create-assessment#retrieve_token). If valid,
            /// returns an App Check token AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the web app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeRecaptchaEnterpriseTokenRequest ExchangeRecaptchaEnterpriseToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaEnterpriseTokenRequest body, string app)
            {
                return new ExchangeRecaptchaEnterpriseTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a [reCAPTCHA Enterprise response
            /// token](https://cloud.google.com/recaptcha-enterprise/docs/create-assessment#retrieve_token). If valid,
            /// returns an App Check token AppCheckToken.
            /// </summary>
            public class ExchangeRecaptchaEnterpriseTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeRecaptchaEnterpriseToken request.</summary>
                public ExchangeRecaptchaEnterpriseTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaEnterpriseTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the web app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaEnterpriseTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeRecaptchaEnterpriseToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeRecaptchaEnterpriseToken";

                /// <summary>Initializes ExchangeRecaptchaEnterpriseToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a [reCAPTCHA v3 response token](https://developers.google.com/recaptcha/docs/v3). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the web app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeRecaptchaTokenRequest ExchangeRecaptchaToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaTokenRequest body, string app)
            {
                return new ExchangeRecaptchaTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a [reCAPTCHA v3 response token](https://developers.google.com/recaptcha/docs/v3). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            public class ExchangeRecaptchaTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeRecaptchaToken request.</summary>
                public ExchangeRecaptchaTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the web app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeRecaptchaToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeRecaptchaToken";

                /// <summary>Initializes ExchangeRecaptchaToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a [reCAPTCHA v3 response token](https://developers.google.com/recaptcha/docs/v3). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the web app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeRecaptchaV3TokenRequest ExchangeRecaptchaV3Token(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaV3TokenRequest body, string app)
            {
                return new ExchangeRecaptchaV3TokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a [reCAPTCHA v3 response token](https://developers.google.com/recaptcha/docs/v3). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            public class ExchangeRecaptchaV3TokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeRecaptchaV3Token request.</summary>
                public ExchangeRecaptchaV3TokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaV3TokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the web app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeRecaptchaV3TokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeRecaptchaV3Token";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeRecaptchaV3Token";

                /// <summary>Initializes ExchangeRecaptchaV3Token parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Validates a [SafetyNet
            /// token](https://developer.android.com/training/safetynet/attestation#request-attestation-step). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the Android app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual ExchangeSafetyNetTokenRequest ExchangeSafetyNetToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeSafetyNetTokenRequest body, string app)
            {
                return new ExchangeSafetyNetTokenRequest(service, body, app);
            }

            /// <summary>
            /// Validates a [SafetyNet
            /// token](https://developer.android.com/training/safetynet/attestation#request-attestation-step). If valid,
            /// returns an AppCheckToken.
            /// </summary>
            public class ExchangeSafetyNetTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaAppCheckToken>
            {
                /// <summary>Constructs a new ExchangeSafetyNetToken request.</summary>
                public ExchangeSafetyNetTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeSafetyNetTokenRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the Android app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaExchangeSafetyNetTokenRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "exchangeSafetyNetToken";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:exchangeSafetyNetToken";

                /// <summary>Initializes ExchangeSafetyNetToken parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Generates a challenge that protects the integrity of an immediately following call to
            /// ExchangeAppAttestAttestation or ExchangeAppAttestAssertion. A challenge should not be reused for
            /// multiple calls.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the iOS app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual GenerateAppAttestChallengeRequest GenerateAppAttestChallenge(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest body, string app)
            {
                return new GenerateAppAttestChallengeRequest(service, body, app);
            }

            /// <summary>
            /// Generates a challenge that protects the integrity of an immediately following call to
            /// ExchangeAppAttestAttestation or ExchangeAppAttestAssertion. A challenge should not be reused for
            /// multiple calls.
            /// </summary>
            public class GenerateAppAttestChallengeRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeResponse>
            {
                /// <summary>Constructs a new GenerateAppAttestChallenge request.</summary>
                public GenerateAppAttestChallengeRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the iOS app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generateAppAttestChallenge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:generateAppAttestChallenge";

                /// <summary>Initializes GenerateAppAttestChallenge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Generates a challenge that protects the integrity of an immediately following integrity verdict request
            /// to the Play Integrity API. The next call to ExchangePlayIntegrityToken using the resulting integrity
            /// token will verify the presence and validity of the challenge. A challenge should not be reused for
            /// multiple calls.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="app">
            /// Required. The relative resource name of the app, in the format: ```
            /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be replaced
            /// with the project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </param>
            public virtual GeneratePlayIntegrityChallengeRequest GeneratePlayIntegrityChallenge(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeRequest body, string app)
            {
                return new GeneratePlayIntegrityChallengeRequest(service, body, app);
            }

            /// <summary>
            /// Generates a challenge that protects the integrity of an immediately following integrity verdict request
            /// to the Play Integrity API. The next call to ExchangePlayIntegrityToken using the resulting integrity
            /// token will verify the presence and validity of the challenge. A challenge should not be reused for
            /// multiple calls.
            /// </summary>
            public class GeneratePlayIntegrityChallengeRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeResponse>
            {
                /// <summary>Constructs a new GeneratePlayIntegrityChallenge request.</summary>
                public GeneratePlayIntegrityChallengeRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeRequest body, string app) : base(service)
                {
                    App = app;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the app, in the format: ```
                /// projects/{project_number}/apps/{app_id} ``` If necessary, the `project_number` element can be
                /// replaced with the project ID of the Firebase project. Learn more about using project identifiers in
                /// Google's [AIP 2510](https://google.aip.dev/cloud/2510) standard.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("app", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string App { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generatePlayIntegrityChallenge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+app}:generatePlayIntegrityChallenge";

                /// <summary>Initializes GeneratePlayIntegrityChallenge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("app", new Google.Apis.Discovery.Parameter
                    {
                        Name = "app",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/apps/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Services resource.</summary>
        public virtual ServicesResource Services { get; }

        /// <summary>The "services" collection of methods.</summary>
        public class ServicesResource
        {
            private const string Resource = "services";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Atomically updates the specified Service configurations.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent project name shared by all Service configurations being updated, in the format ```
            /// projects/{project_number} ``` The parent collection in the `name` field of any resource being updated
            /// must match this field, or the entire batch fails.
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchUpdateServicesRequest body, string parent)
            {
                return new BatchUpdateRequest(service, body, parent);
            }

            /// <summary>Atomically updates the specified Service configurations.</summary>
            public class BatchUpdateRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchUpdateServicesResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchUpdateServicesRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent project name shared by all Service configurations being updated, in the format
                /// ``` projects/{project_number} ``` The parent collection in the `name` field of any resource being
                /// updated must match this field, or the entire batch fails.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaBatchUpdateServicesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/services:batchUpdate";

                /// <summary>Initializes BatchUpdate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the Service configuration for the specified service name.</summary>
            /// <param name="name">
            /// Required. The relative resource name of the Service to retrieve, in the format: ```
            /// projects/{project_number}/services/{service_id} ``` Note that the `service_id` element must be a
            /// supported service ID. Currently, the following service IDs are supported: *
            /// `firebasestorage.googleapis.com` (Cloud Storage for Firebase) * `firebasedatabase.googleapis.com`
            /// (Firebase Realtime Database) * `firestore.googleapis.com` (Cloud Firestore) *
            /// `identitytoolkit.googleapis.com` (Firebase Authentication with Identity Platform)
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the Service configuration for the specified service name.</summary>
            public class GetRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaService>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the Service to retrieve, in the format: ```
                /// projects/{project_number}/services/{service_id} ``` Note that the `service_id` element must be a
                /// supported service ID. Currently, the following service IDs are supported: *
                /// `firebasestorage.googleapis.com` (Cloud Storage for Firebase) * `firebasedatabase.googleapis.com`
                /// (Firebase Realtime Database) * `firestore.googleapis.com` (Cloud Firestore) *
                /// `identitytoolkit.googleapis.com` (Firebase Authentication with Identity Platform)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/services/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists all Service configurations for the specified project. Only Services which were explicitly
            /// configured using UpdateService or BatchUpdateServices will be returned.
            /// </summary>
            /// <param name="parent">
            /// Required. The relative resource name of the parent project for which to list each associated Service, in
            /// the format: ``` projects/{project_number} ```
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists all Service configurations for the specified project. Only Services which were explicitly
            /// configured using UpdateService or BatchUpdateServices will be returned.
            /// </summary>
            public class ListRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaListServicesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the parent project for which to list each associated
                /// Service, in the format: ``` projects/{project_number} ```
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of Services to return in the response. Only explicitly configured services are
                /// returned. The server may return fewer than this at its own discretion. If no value is specified or
                /// set to zero (or too large a value is specified), the server will impose its own limit.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Token returned from a previous call to ListServices indicating where in the set of Services to
                /// resume listing. Provide this to retrieve the subsequent page. When paginating, all other parameters
                /// provided to ListServices must match the call that provided the page token; if they do not match, the
                /// result is undefined.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/services";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates the specified Service configuration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The relative resource name of the service configuration object, in the format: ```
            /// projects/{project_number}/services/{service_id} ``` Note that the `service_id` element must be a
            /// supported service ID. Currently, the following service IDs are supported: *
            /// `firebasestorage.googleapis.com` (Cloud Storage for Firebase) * `firebasedatabase.googleapis.com`
            /// (Firebase Realtime Database) * `firestore.googleapis.com` (Cloud Firestore) *
            /// `identitytoolkit.googleapis.com` (Firebase Authentication with Identity Platform)
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaService body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates the specified Service configuration.</summary>
            public class PatchRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaService>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaService body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The relative resource name of the service configuration object, in the format: ```
                /// projects/{project_number}/services/{service_id} ``` Note that the `service_id` element must be a
                /// supported service ID. Currently, the following service IDs are supported: *
                /// `firebasestorage.googleapis.com` (Cloud Storage for Firebase) * `firebasedatabase.googleapis.com`
                /// (Firebase Realtime Database) * `firestore.googleapis.com` (Cloud Firestore) *
                /// `identitytoolkit.googleapis.com` (Firebase Authentication with Identity Platform)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. A comma-separated list of names of fields in the Service to update. Example:
                /// `enforcement_mode`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaService Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/services/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Verifies the given App Check token and returns token usage signals that callers may act upon. This method
        /// currently only supports App Check tokens exchanged from the following attestation providers: * Play
        /// Integrity API * App Attest * DeviceCheck (`DCDevice` tokens) * reCAPTCHA Enterprise * reCAPTCHA v3 * Custom
        /// providers App Check tokens exchanged from debug secrets are also supported. Calling this method on an
        /// otherwise valid App Check token with an unsupported provider will cause an HTTP 400 error to be returned.
        /// Returns whether this token was already consumed before this call. If this is the first time this method has
        /// seen the given App Check token, the field `already_consumed` in the response will be absent. The given token
        /// will then be marked as `already_consumed` (set to `true`) for all future invocations of this method for that
        /// token. Note that if the given App Check token is invalid, an HTTP 403 error is returned instead of a
        /// response object, regardless whether the token was already consumed. Currently, when evaluating whether an
        /// App Check token was already consumed, only calls to this exact method are counted. Use of the App Check
        /// token elsewhere will not mark the token as being already consumed. The caller must have the
        /// [`firebaseappcheck.appCheckTokens.verify`](https://firebase.google.com/docs/projects/iam/permissions#app-check)
        /// permission to call this method. This permission is part of the [Firebase App Check Token Verifier
        /// role](https://firebase.google.com/docs/projects/iam/roles-predefined-product#app-check).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">
        /// Required. The relative resource name of the project for which the token was minted, in the format: ```
        /// projects/{project_number} ``` If necessary, the `project_number` element can be replaced with the project ID
        /// of the Firebase project. Learn more about using project identifiers in Google's [AIP
        /// 2510](https://google.aip.dev/cloud/2510) standard.
        /// </param>
        public virtual VerifyAppCheckTokenRequest VerifyAppCheckToken(Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenRequest body, string project)
        {
            return new VerifyAppCheckTokenRequest(service, body, project);
        }

        /// <summary>
        /// Verifies the given App Check token and returns token usage signals that callers may act upon. This method
        /// currently only supports App Check tokens exchanged from the following attestation providers: * Play
        /// Integrity API * App Attest * DeviceCheck (`DCDevice` tokens) * reCAPTCHA Enterprise * reCAPTCHA v3 * Custom
        /// providers App Check tokens exchanged from debug secrets are also supported. Calling this method on an
        /// otherwise valid App Check token with an unsupported provider will cause an HTTP 400 error to be returned.
        /// Returns whether this token was already consumed before this call. If this is the first time this method has
        /// seen the given App Check token, the field `already_consumed` in the response will be absent. The given token
        /// will then be marked as `already_consumed` (set to `true`) for all future invocations of this method for that
        /// token. Note that if the given App Check token is invalid, an HTTP 403 error is returned instead of a
        /// response object, regardless whether the token was already consumed. Currently, when evaluating whether an
        /// App Check token was already consumed, only calls to this exact method are counted. Use of the App Check
        /// token elsewhere will not mark the token as being already consumed. The caller must have the
        /// [`firebaseappcheck.appCheckTokens.verify`](https://firebase.google.com/docs/projects/iam/permissions#app-check)
        /// permission to call this method. This permission is part of the [Firebase App Check Token Verifier
        /// role](https://firebase.google.com/docs/projects/iam/roles-predefined-product#app-check).
        /// </summary>
        public class VerifyAppCheckTokenRequest : FirebaseappcheckBaseServiceRequest<Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenResponse>
        {
            /// <summary>Constructs a new VerifyAppCheckToken request.</summary>
            public VerifyAppCheckTokenRequest(Google.Apis.Services.IClientService service, Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenRequest body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The relative resource name of the project for which the token was minted, in the format: ```
            /// projects/{project_number} ``` If necessary, the `project_number` element can be replaced with the
            /// project ID of the Firebase project. Learn more about using project identifiers in Google's [AIP
            /// 2510](https://google.aip.dev/cloud/2510) standard.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Project { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Firebaseappcheck.v1beta.Data.GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verifyAppCheckToken";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta/{+project}:verifyAppCheckToken";

            /// <summary>Initializes VerifyAppCheckToken parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+$",
                });
            }
        }
    }
}
namespace Google.Apis.Firebaseappcheck.v1beta.Data
{
    /// <summary>
    /// An app's App Attest configuration object. This configuration controls certain properties of the `AppCheckToken`
    /// returned by ExchangeAppAttestAttestation and ExchangeAppAttestAssertion, such as its ttl. Note that the Team ID
    /// registered with your app is used as part of the validation process. Please register it via the Firebase Console
    /// or programmatically via the [Firebase Management
    /// Service](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects.iosApps/patch).
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaAppAttestConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the App Attest configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/appAttestConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from App Attest artifacts will be valid. If
        /// unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates an *App Check token*, which are used to access Firebase services protected by App Check.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaAppCheckToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An App Check token. App Check tokens are signed [JWTs](https://tools.ietf.org/html/rfc7519) containing
        /// claims that identify the attested app and Firebase project. This token is used to access Firebase services
        /// protected by App Check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationToken")]
        public virtual string AttestationToken { get; set; }

        /// <summary>
        /// An App Check token. App Check tokens are signed [JWTs](https://tools.ietf.org/html/rfc7519) containing
        /// claims that identify the attested app and Firebase project. This token is used to access Firebase services
        /// protected by App Check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// The duration from the time this token is minted until its expiration. This field is intended to ease
        /// client-side token management, since the client may have clock skew, but is still able to accurately measure
        /// a duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Encapsulates an *App Check token*, which are used to access Firebase services protected by App Check.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaAttestationTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An App Check token. App Check tokens are signed [JWTs](https://tools.ietf.org/html/rfc7519) containing
        /// claims that identify the attested app and Firebase project. This token is used to access Firebase services
        /// protected by App Check.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationToken")]
        public virtual string AttestationToken { get; set; }

        /// <summary>
        /// The duration from the time this token is minted until its expiration. This field is intended to ease
        /// client-side token management, since the client may have clock skew, but is still able to accurately measure
        /// a duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetAppAttestConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetAppAttestConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AppAttestConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaAppAttestConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetDeviceCheckConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetDeviceCheckConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DeviceCheckConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaDeviceCheckConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetPlayIntegrityConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetPlayIntegrityConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>PlayIntegrityConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaPlayIntegrityConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetRecaptchaConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetRecaptchaConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RecaptchaConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaRecaptchaConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetRecaptchaEnterpriseConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetRecaptchaEnterpriseConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RecaptchaEnterpriseConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetRecaptchaV3Configs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetRecaptchaV3ConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RecaptchaV3Configs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaRecaptchaV3Config> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchGetSafetyNetConfigs method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchGetSafetyNetConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SafetyNetConfigs retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configs")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaSafetyNetConfig> Configs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the BatchUpdateServices method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchUpdateServicesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request messages specifying the Services to update. A maximum of 100 objects can be updated in
        /// a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaUpdateServiceRequest> Requests { get; set; }

        /// <summary>
        /// Optional. A comma-separated list of names of fields in the Services to update. Example: `display_name`. If
        /// this field is present, the `update_mask` field in the UpdateServiceRequest messages must all match this
        /// field, or the entire batch fails and no updates will be committed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchUpdateServices method.</summary>
    public class GoogleFirebaseAppcheckV1betaBatchUpdateServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Service objects after the updates have been applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaService> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A *debug token* is a secret used during the development or integration testing of an app. It essentially allows
    /// the development or integration testing to bypass app attestation while still allowing App Check to enforce
    /// protection on supported production Firebase services.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaDebugToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A human readable display name used to identify this debug token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. The relative resource name of the debug token, in the format: ```
        /// projects/{project_number}/apps/{app_id}/debugTokens/{debug_token_id} ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. Immutable. The secret token itself. Must be provided during creation, and must be a
        /// UUID4, case insensitive. This field is immutable once set, and cannot be provided during an UpdateDebugToken
        /// request. You can, however, delete this debug token using DeleteDebugToken to revoke it. For security
        /// reasons, this field will never be populated in any response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's DeviceCheck configuration object. This configuration is used by ExchangeDeviceCheckToken to validate
    /// device tokens issued to apps by DeviceCheck. It also controls certain properties of the returned
    /// `AppCheckToken`, such as its ttl. Note that the Team ID registered with your app is used as part of the
    /// validation process. Please register it via the Firebase Console or programmatically via the [Firebase Management
    /// Service](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects.iosApps/patch).
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaDeviceCheckConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The key identifier of a private key enabled with DeviceCheck, created in your Apple Developer
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// Required. The relative resource name of the DeviceCheck configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/deviceCheckConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. The contents of the private key (`.p8`) file associated with the key specified by
        /// `key_id`. For security reasons, this field will never be populated in any response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKey")]
        public virtual string PrivateKey { get; set; }

        /// <summary>
        /// Output only. Whether the `private_key` field was previously set. Since we will never return the
        /// `private_key` field, this field is the only way to find out whether it was previously set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateKeySet")]
        public virtual System.Nullable<bool> PrivateKeySet { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from DeviceCheck tokens will be valid. If unset,
        /// a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeAppAttestAssertion method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeAppAttestAssertionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The artifact returned by a previous call to ExchangeAppAttestAttestation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifact")]
        public virtual string Artifact { get; set; }

        /// <summary>Required. The CBOR-encoded assertion returned by the client-side App Attest API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assertion")]
        public virtual string Assertion { get; set; }

        /// <summary>
        /// Required. A one-time challenge returned by an immediately prior call to GenerateAppAttestChallenge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string Challenge { get; set; }

        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeAppAttestAttestation method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The App Attest statement returned by the client-side App Attest API. This is a base64url encoded
        /// CBOR object in the JSON response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationStatement")]
        public virtual string AttestationStatement { get; set; }

        /// <summary>
        /// Required. A one-time challenge returned by an immediately prior call to GenerateAppAttestChallenge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string Challenge { get; set; }

        /// <summary>Required. The key ID generated by App Attest for the client app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyId")]
        public virtual string KeyId { get; set; }

        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ExchangeAppAttestAttestation method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeAppAttestAttestationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Encapsulates an App Check token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCheckToken")]
        public virtual GoogleFirebaseAppcheckV1betaAppCheckToken AppCheckToken { get; set; }

        /// <summary>An artifact that can be used in future calls to ExchangeAppAttestAssertion.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("artifact")]
        public virtual string Artifact { get; set; }

        /// <summary>Encapsulates an App Check token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attestationToken")]
        public virtual GoogleFirebaseAppcheckV1betaAttestationTokenResponse AttestationToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeCustomToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeCustomTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A custom token signed using your project's Admin SDK service account credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customToken")]
        public virtual string CustomToken { get; set; }

        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeDebugToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeDebugTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A debug token secret. This string must match a debug token secret previously created using
        /// CreateDebugToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugToken")]
        public virtual string DebugToken { get; set; }

        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeDeviceCheckToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeDeviceCheckTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The `device_token` as returned by Apple's client-side [DeviceCheck
        /// API](https://developer.apple.com/documentation/devicecheck/dcdevice). This is the base64 encoded `Data`
        /// (Swift) or `NSData` (ObjC) object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceToken")]
        public virtual string DeviceToken { get; set; }

        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangePlayIntegrityToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangePlayIntegrityTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>
        /// Required. The [integrity verdict response token from Play
        /// Integrity](https://developer.android.com/google/play/integrity/verdict#decrypt-verify) issued to your app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playIntegrityToken")]
        public virtual string PlayIntegrityToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeRecaptchaEnterpriseToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeRecaptchaEnterpriseTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>
        /// Required. The reCAPTCHA token as returned by the [reCAPTCHA Enterprise JavaScript
        /// API](https://cloud.google.com/recaptcha-enterprise/docs/instrument-web-pages).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recaptchaEnterpriseToken")]
        public virtual string RecaptchaEnterpriseToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeRecaptchaToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeRecaptchaTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The reCAPTCHA token as returned by the [reCAPTCHA v3 JavaScript
        /// API](https://developers.google.com/recaptcha/docs/v3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recaptchaToken")]
        public virtual string RecaptchaToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeRecaptchaV3Token method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeRecaptchaV3TokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Forces a short-lived token with a 5 minute TTL. Useful when the client wishes to impose stricter TTL
        /// requirements for this exchange. Default: false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limitedUse")]
        public virtual System.Nullable<bool> LimitedUse { get; set; }

        /// <summary>
        /// Required. The reCAPTCHA token as returned by the [reCAPTCHA v3 JavaScript
        /// API](https://developers.google.com/recaptcha/docs/v3).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recaptchaV3Token")]
        public virtual string RecaptchaV3Token { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the ExchangeSafetyNetToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaExchangeSafetyNetTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The [SafetyNet attestation
        /// response](https://developer.android.com/training/safetynet/attestation#request-attestation-step) issued to
        /// your app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyNetToken")]
        public virtual string SafetyNetToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the GenerateAppAttestChallenge method.</summary>
    public class GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the GenerateAppAttestChallenge method.</summary>
    public class GoogleFirebaseAppcheckV1betaGenerateAppAttestChallengeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A one-time use challenge for the client to pass to the App Attest API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string Challenge { get; set; }

        /// <summary>
        /// The duration from the time this challenge is minted until its expiration. This field is intended to ease
        /// client-side token management, since the client may have clock skew, but is still able to accurately measure
        /// a duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the GeneratePlayIntegrityChallenge method.</summary>
    public class GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the GeneratePlayIntegrityChallenge method.</summary>
    public class GoogleFirebaseAppcheckV1betaGeneratePlayIntegrityChallengeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A one-time use
        /// [challenge](https://developer.android.com/google/play/integrity/verdict#protect-against-replay-attacks) for
        /// the client to pass to the Play Integrity API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("challenge")]
        public virtual string Challenge { get; set; }

        /// <summary>
        /// The duration from the time this challenge is minted until its expiration. This field is intended to ease
        /// client-side token management, since the client may have clock skew, but is still able to accurately measure
        /// a duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListDebugTokens method.</summary>
    public class GoogleFirebaseAppcheckV1betaListDebugTokensResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DebugTokens retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugTokens")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaDebugToken> DebugTokens { get; set; }

        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty or omitted, then this response is the last page of results. This token can be used in a subsequent
        /// call to ListDebugTokens to find the next group of DebugTokens. Page tokens are short-lived and should not be
        /// persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListServices method.</summary>
    public class GoogleFirebaseAppcheckV1betaListServicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the result list is too large to fit in a single response, then a token is returned. If the string is
        /// empty or omitted, then this response is the last page of results. This token can be used in a subsequent
        /// call to ListServices to find the next group of Services. Page tokens are short-lived and should not be
        /// persisted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The Services retrieved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("services")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaService> Services { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's Play Integrity configuration object. This configuration controls certain properties of the
    /// `AppCheckToken` returned by ExchangePlayIntegrityToken, such as its ttl. Note that your registered SHA-256
    /// certificate fingerprints are used to validate tokens issued by the Play Integrity API; please register them via
    /// the Firebase Console or programmatically via the [Firebase Management
    /// Service](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects.androidApps.sha/create).
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaPlayIntegrityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the Play Integrity configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/playIntegrityConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from Play Integrity tokens will be valid. If
        /// unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A JWK as specified by [section 4 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-4) and [section 6.3.1
    /// of RFC 7518](https://tools.ietf.org/html/rfc7518#section-6.3.1).
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaPublicJwk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>See [section 4.4 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-4.4).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alg")]
        public virtual string Alg { get; set; }

        /// <summary>See [section 6.3.1.2 of RFC 7518](https://tools.ietf.org/html/rfc7518#section-6.3.1.2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("e")]
        public virtual string E { get; set; }

        /// <summary>See [section 4.5 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-4.5).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kid")]
        public virtual string Kid { get; set; }

        /// <summary>See [section 4.1 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-4.1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kty")]
        public virtual string Kty { get; set; }

        /// <summary>See [section 6.3.1.1 of RFC 7518](https://tools.ietf.org/html/rfc7518#section-6.3.1.1).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("n")]
        public virtual string N { get; set; }

        /// <summary>See [section 4.2 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-4.2).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("use")]
        public virtual string Use { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The currently active set of public keys that can be used to verify App Check tokens. This object is a JWK set as
    /// specified by [section 5 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-5). For security, the response
    /// **must not** be cached for longer than six hours.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaPublicJwkSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of public keys. See [section 5.1 of RFC 7517](https://tools.ietf.org/html/rfc7517#section-5).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<GoogleFirebaseAppcheckV1betaPublicJwk> Keys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's reCAPTCHA v3 configuration object. This configuration is used by ExchangeRecaptchaToken to validate
    /// reCAPTCHA tokens issued to apps by reCAPTCHA v3. It also controls certain properties of the returned
    /// `AppCheckToken`, such as its ttl.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaRecaptchaConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/recaptchaConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. The site secret used to identify your service for reCAPTCHA v3 verification. For
        /// security reasons, this field will never be populated in any response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSecret")]
        public virtual string SiteSecret { get; set; }

        /// <summary>
        /// Output only. Whether the `site_secret` field was previously set. Since we will never return the
        /// `site_secret` field, this field is the only way to find out whether it was previously set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSecretSet")]
        public virtual System.Nullable<bool> SiteSecretSet { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA tokens will be valid. If unset, a
        /// default value of 1 day is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's reCAPTCHA Enterprise configuration object. This configuration is used by
    /// ExchangeRecaptchaEnterpriseToken to validate reCAPTCHA tokens issued to apps by reCAPTCHA Enterprise. It also
    /// controls certain properties of the returned `AppCheckToken`, such as its ttl.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaRecaptchaEnterpriseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the reCAPTCHA Enterprise configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/recaptchaEnterpriseConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The score-based site key [created in reCAPTCHA
        /// Enterprise](https://cloud.google.com/recaptcha-enterprise/docs/create-key#creating_a_site_key) used to
        /// [invoke reCAPTCHA and generate the reCAPTCHA
        /// tokens](https://cloud.google.com/recaptcha-enterprise/docs/instrument-web-pages) for your application.
        /// Important: This is *not* the `site_secret` (as it is in reCAPTCHA v3), but rather your score-based reCAPTCHA
        /// Enterprise site key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteKey")]
        public virtual string SiteKey { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA Enterprise tokens will be valid.
        /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's reCAPTCHA v3 configuration object. This configuration is used by ExchangeRecaptchaV3Token to validate
    /// reCAPTCHA tokens issued to apps by reCAPTCHA v3. It also controls certain properties of the returned
    /// `AppCheckToken`, such as its ttl.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaRecaptchaV3Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the reCAPTCHA v3 configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/recaptchaV3Config ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Input only. The site secret used to identify your service for reCAPTCHA v3 verification. For
        /// security reasons, this field will never be populated in any response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSecret")]
        public virtual string SiteSecret { get; set; }

        /// <summary>
        /// Output only. Whether the `site_secret` field was previously set. Since we will never return the
        /// `site_secret` field, this field is the only way to find out whether it was previously set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteSecretSet")]
        public virtual System.Nullable<bool> SiteSecretSet { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA tokens will be valid. If unset, a
        /// default value of 1 day is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An app's SafetyNet configuration object. This configuration controls certain properties of the `AppCheckToken`
    /// returned by ExchangeSafetyNetToken, such as its ttl. Note that your registered SHA-256 certificate fingerprints
    /// are used to validate tokens issued by SafetyNet; please register them via the Firebase Console or
    /// programmatically via the [Firebase Management
    /// Service](https://firebase.google.com/docs/projects/api/reference/rest/v1beta1/projects.androidApps.sha/create).
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaSafetyNetConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The relative resource name of the SafetyNet configuration object, in the format: ```
        /// projects/{project_number}/apps/{app_id}/safetyNetConfig ```
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Specifies the duration for which App Check tokens exchanged from SafetyNet tokens will be valid. If unset, a
        /// default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenTtl")]
        public virtual object TokenTtl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The enforcement configuration for a Firebase service supported by App Check.</summary>
    public class GoogleFirebaseAppcheckV1betaService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The App Check enforcement mode for this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enforcementMode")]
        public virtual string EnforcementMode { get; set; }

        /// <summary>
        /// This checksum is computed by the server based on the value of other fields, and may be sent on update and
        /// delete requests to ensure the client has an up-to-date value before proceeding. This etag is strongly
        /// validated as defined by RFC 7232.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. The relative resource name of the service configuration object, in the format: ```
        /// projects/{project_number}/services/{service_id} ``` Note that the `service_id` element must be a supported
        /// service ID. Currently, the following service IDs are supported: * `firebasestorage.googleapis.com` (Cloud
        /// Storage for Firebase) * `firebasedatabase.googleapis.com` (Firebase Realtime Database) *
        /// `firestore.googleapis.com` (Cloud Firestore) * `identitytoolkit.googleapis.com` (Firebase Authentication
        /// with Identity Platform)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Timestamp when this service configuration object was most recently updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }
    }

    /// <summary>
    /// Request message for the UpdateService method as well as an individual update message for the BatchUpdateServices
    /// method.
    /// </summary>
    public class GoogleFirebaseAppcheckV1betaUpdateServiceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The Service to update. The Service's `name` field is used to identify the Service to be updated,
        /// in the format: ``` projects/{project_number}/services/{service_id} ``` Note that the `service_id` element
        /// must be a supported service ID. Currently, the following service IDs are supported: *
        /// `firebasestorage.googleapis.com` (Cloud Storage for Firebase) * `firebasedatabase.googleapis.com` (Firebase
        /// Realtime Database) * `firestore.googleapis.com` (Cloud Firestore) * `identitytoolkit.googleapis.com`
        /// (Firebase Authentication with Identity Platform) For Firebase Authentication to work with App Check, you
        /// must first upgrade to [Firebase Authentication with Identity
        /// Platform](https://firebase.google.com/docs/auth#identity-platform).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual GoogleFirebaseAppcheckV1betaService Service { get; set; }

        /// <summary>
        /// Required. A comma-separated list of names of fields in the Service to update. Example: `enforcement_mode`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the VerifyAppCheckToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The App Check token to verify. App Check tokens exchanged from the SafetyNet provider are not
        /// supported; an HTTP 400 error will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appCheckToken")]
        public virtual string AppCheckToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the VerifyAppCheckToken method.</summary>
    public class GoogleFirebaseAppcheckV1betaVerifyAppCheckTokenResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether this token was already consumed. If this is the first time this method has seen the given App Check
        /// token, this field will be omitted from the response. The given token will then be marked as
        /// `already_consumed` (set to `true`) for all future invocations of this method for that token. Note that if
        /// the given App Check token is invalid, an HTTP 403 error is returned instead of a response containing this
        /// field, regardless whether the token was already consumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alreadyConsumed")]
        public virtual System.Nullable<bool> AlreadyConsumed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
