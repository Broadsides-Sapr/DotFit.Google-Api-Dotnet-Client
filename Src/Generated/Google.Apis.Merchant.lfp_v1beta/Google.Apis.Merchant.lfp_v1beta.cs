// Copyright 2024 Google LLC
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

namespace Google.Apis.Merchant.lfp_v1beta
{
    /// <summary>The Merchant Service.</summary>
    public class MerchantService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "lfp_v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MerchantService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MerchantService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://merchantapi.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://merchantapi.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "merchantapi";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Merchant API.</summary>
        public class Scope
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public static string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Merchant API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your product listings and accounts for Google Shopping</summary>
            public const string Content = "https://www.googleapis.com/auth/content";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }
    }

    /// <summary>A base abstract class for Merchant requests.</summary>
    public abstract class MerchantBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MerchantBaseServiceRequest instance.</summary>
        protected MerchantBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Merchant parameter list.</summary>
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

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            LfpInventories = new LfpInventoriesResource(service);
            LfpSales = new LfpSalesResource(service);
            LfpStores = new LfpStoresResource(service);
        }

        /// <summary>Gets the LfpInventories resource.</summary>
        public virtual LfpInventoriesResource LfpInventories { get; }

        /// <summary>The "lfpInventories" collection of methods.</summary>
        public class LfpInventoriesResource
        {
            private const string Resource = "lfpInventories";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LfpInventoriesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Inserts a `LfpInventory` resource for the given target merchant account. If the resource already exists,
            /// it will be replaced. The inventory automatically expires after 30 days.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The LFP provider account. Format: `accounts/{account}`</param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.lfp_v1beta.Data.LfpInventory body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Inserts a `LfpInventory` resource for the given target merchant account. If the resource already exists,
            /// it will be replaced. The inventory automatically expires after 30 days.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.LfpInventory>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.lfp_v1beta.Data.LfpInventory body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The LFP provider account. Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.lfp_v1beta.Data.LfpInventory Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+parent}/lfpInventories:insert";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the LfpSales resource.</summary>
        public virtual LfpSalesResource LfpSales { get; }

        /// <summary>The "lfpSales" collection of methods.</summary>
        public class LfpSalesResource
        {
            private const string Resource = "lfpSales";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LfpSalesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Inserts a `LfpSale` for the given merchant.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The LFP provider account. Format: `accounts/{lfp_partner}`</param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.lfp_v1beta.Data.LfpSale body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>Inserts a `LfpSale` for the given merchant.</summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.LfpSale>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.lfp_v1beta.Data.LfpSale body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The LFP provider account. Format: `accounts/{lfp_partner}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.lfp_v1beta.Data.LfpSale Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+parent}/lfpSales:insert";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the LfpStores resource.</summary>
        public virtual LfpStoresResource LfpStores { get; }

        /// <summary>The "lfpStores" collection of methods.</summary>
        public class LfpStoresResource
        {
            private const string Resource = "lfpStores";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LfpStoresResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a store for a target merchant.</summary>
            /// <param name="name">
            /// Required. The name of the store to delete for the target merchant account. Format:
            /// `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a store for a target merchant.</summary>
            public class DeleteRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the store to delete for the target merchant account. Format:
                /// `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/lfpStores/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves information about a store.</summary>
            /// <param name="name">
            /// Required. The name of the store to retrieve. Format:
            /// `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves information about a store.</summary>
            public class GetRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.LfpStore>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the store to retrieve. Format:
                /// `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+name}";

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
                        Pattern = @"^accounts/[^/]+/lfpStores/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Inserts a store for the target merchant. If the store with the same store code already exists, it will
            /// be replaced.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. The LFP provider account Format: `accounts/{account}`</param>
            public virtual InsertRequest Insert(Google.Apis.Merchant.lfp_v1beta.Data.LfpStore body, string parent)
            {
                return new InsertRequest(this.service, body, parent);
            }

            /// <summary>
            /// Inserts a store for the target merchant. If the store with the same store code already exists, it will
            /// be replaced.
            /// </summary>
            public class InsertRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.LfpStore>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Merchant.lfp_v1beta.Data.LfpStore body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The LFP provider account Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Merchant.lfp_v1beta.Data.LfpStore Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+parent}/lfpStores:insert";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accounts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the stores of the target merchant, specified by the filter in `ListLfpStoresRequest`.
            /// </summary>
            /// <param name="parent">Required. The LFP partner. Format: `accounts/{account}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the stores of the target merchant, specified by the filter in `ListLfpStoresRequest`.
            /// </summary>
            public class ListRequest : MerchantBaseServiceRequest<Google.Apis.Merchant.lfp_v1beta.Data.ListLfpStoresResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. The LFP partner. Format: `accounts/{account}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. The maximum number of `LfpStore` resources for the given account to return. The service
                /// returns fewer than this value if the number of stores for the given account is less than the
                /// `pageSize`. The default value is 250. The maximum value is 1000; If a value higher than the maximum
                /// is specified, then the `pageSize` will default to the maximum.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListLfpStoresRequest` call. Provide the page token
                /// to retrieve the subsequent page. When paginating, all other parameters provided to
                /// `ListLfpStoresRequest` must match the call that provided the page token. The token returned as
                /// nextPageToken in the response to the previous request.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Required. The Merchant Center id of the merchant to list stores for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("targetAccount", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> TargetAccount { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "lfp/v1beta/{+parent}/lfpStores";

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
                        Pattern = @"^accounts/[^/]+$",
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
                    RequestParameters.Add("targetAccount", new Google.Apis.Discovery.Parameter
                    {
                        Name = "targetAccount",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Merchant.lfp_v1beta.Data
{
    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Local Inventory for the merchant.</summary>
    public class LfpInventory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Availability of the product at this store. For accepted attribute values, see the [local product
        /// inventory data specification](https://support.google.com/merchants/answer/3061342)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availability")]
        public virtual string Availability { get; set; }

        private string _collectionTimeRaw;

        private object _collectionTime;

        /// <summary>
        /// Optional. The time when the inventory is collected. If not set, it will be set to the time when the
        /// inventory is submitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collectionTime")]
        public virtual string CollectionTimeRaw
        {
            get => _collectionTimeRaw;
            set
            {
                _collectionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _collectionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CollectionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CollectionTimeDateTimeOffset instead.")]
        public virtual object CollectionTime
        {
            get => _collectionTime;
            set
            {
                _collectionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _collectionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CollectionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CollectionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CollectionTimeRaw);
            set => CollectionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. The [feed label](https://developers.google.com/shopping-content/guides/products/feed-labels) for
        /// the product. If this is not set, it will default to `regionCode`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>Optional. The Global Trade Item Number of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; }

        /// <summary>
        /// Output only. Identifier. The name for the `LfpInventory` resource. Format:
        /// `accounts/{account}/lfpInventories/{target_merchant}~{store_code}~{offer}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. Immutable. A unique identifier for the product. If both inventories and sales are submitted for a
        /// merchant, this id should match for the same product. **Note**: if the merchant sells the same product new
        /// and used, they should have different IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// Optional. Supported pickup method for this offer. Unless the value is "not supported", this field must be
        /// submitted together with `pickupSla`. For accepted attribute values, see the [local product inventory data
        /// specification](https://support.google.com/merchants/answer/3061342).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupMethod")]
        public virtual string PickupMethod { get; set; }

        /// <summary>
        /// Optional. Expected date that an order will be ready for pickup relative to the order date. Must be submitted
        /// together with `pickupMethod`. For accepted attribute values, see the [local product inventory data
        /// specification](https://support.google.com/merchants/answer/3061342).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pickupSla")]
        public virtual string PickupSla { get; set; }

        /// <summary>Optional. The current price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>
        /// Optional. Quantity of the product available at this store. Must be greater than or equal to zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>
        /// Required. The [CLDR territory code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml) for
        /// the country where the product is sold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// Required. The identifier of the merchant's store. Either the store code inserted through `InsertLfpStore` or
        /// the store code in the Business Profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

        /// <summary>Required. The Merchant Center ID of the merchant to submit the inventory for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAccount")]
        public virtual System.Nullable<long> TargetAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sale for the merchant.</summary>
    public class LfpSale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The two-letter ISO 639-1 language code for the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Optional. The [feed label](https://developers.google.com/shopping-content/guides/products/feed-labels) for
        /// the product. If this is not set, it will default to `regionCode`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedLabel")]
        public virtual string FeedLabel { get; set; }

        /// <summary>Required. The Global Trade Item Number of the sold product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gtin")]
        public virtual string Gtin { get; set; }

        /// <summary>
        /// Output only. Identifier. The name of the `LfpSale` resource. Format: `accounts/{account}/lfpSales/{sale}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. A unique identifier for the product. If both inventories and sales are submitted for a merchant,
        /// this id should match for the same product. **Note**: if the merchant sells the same product new and used,
        /// they should have different IDs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Required. The unit price of the product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Price Price { get; set; }

        /// <summary>Required. The relative change of the available quantity. Negative for items returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<long> Quantity { get; set; }

        /// <summary>
        /// Required. The [CLDR territory code](https://github.com/unicode-org/cldr/blob/latest/common/main/en.xml) for
        /// the country where the product is sold.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        private string _saleTimeRaw;

        private object _saleTime;

        /// <summary>Required. The timestamp for the sale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saleTime")]
        public virtual string SaleTimeRaw
        {
            get => _saleTimeRaw;
            set
            {
                _saleTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _saleTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="SaleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SaleTimeDateTimeOffset instead.")]
        public virtual object SaleTime
        {
            get => _saleTime;
            set
            {
                _saleTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _saleTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="SaleTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SaleTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(SaleTimeRaw);
            set => SaleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Required. The identifier of the merchant's store. Either a `storeCode` inserted through the API or the code
        /// of the store in the Business Profile.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

        /// <summary>Required. The Merchant Center ID of the merchant to submit the sale for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAccount")]
        public virtual System.Nullable<long> TargetAccount { get; set; }

        /// <summary>Output only. System generated globally unique ID for the `LfpSale`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A store for the merchant. This will be used to match to a store under the Google Business Profile of the target
    /// merchant. If a matching store can't be found, the inventories or sales submitted with the store code will not be
    /// used.
    /// </summary>
    public class LfpStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. [Google My Business category id](https://gcid-explorer.corp.google.com/static/gcid.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcidCategory")]
        public virtual System.Collections.Generic.IList<string> GcidCategory { get; set; }

        /// <summary>
        /// Optional. Output only. The state of matching to a Google Business Profile. See matchingStateHint for further
        /// details if no match is found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingState")]
        public virtual string MatchingState { get; set; }

        /// <summary>
        /// Optional. Output only. The hint of why the matching has failed. This is only set when
        /// matchingState=`STORE_MATCHING_STATE_FAILED`. Possible values are: - "`linked-store-not-found`": There aren't
        /// any Google Business Profile stores available for matching. - "`store-match-not-found`": The provided
        /// `LfpStore` couldn't be matched to any of the connected Google Business Profile stores. Merchant Center
        /// account is connected correctly and stores are available on Google Business Profile, but the `LfpStore`
        /// location address does not match with Google Business Profile stores' addresses. Update the `LfpStore`
        /// address or Google Business Profile store address to match correctly. - "`store-match-unverified`": The
        /// provided `LfpStore` couldn't be matched to any of the connected Google Business Profile stores, as the
        /// matched Google Business Profile store is unverified. Go through the Google Business Profile verification
        /// process to match correctly.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingStateHint")]
        public virtual string MatchingStateHint { get; set; }

        /// <summary>
        /// Output only. Identifier. The name of the `LfpStore` resource. Format:
        /// `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. The store phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. Example:
        /// `+15556767888`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// Optional. The [Google Place
        /// Id](https://developers.google.com/maps/documentation/places/web-service/place-id#id-overview) of the store
        /// location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placeId")]
        public virtual string PlaceId { get; set; }

        /// <summary>
        /// Required. The street address of the store. Example: 1600 Amphitheatre Pkwy, Mountain View, CA 94043, USA.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeAddress")]
        public virtual string StoreAddress { get; set; }

        /// <summary>Required. Immutable. A store identifier that is unique for the target merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeCode")]
        public virtual string StoreCode { get; set; }

        /// <summary>Optional. The merchant or store name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storeName")]
        public virtual string StoreName { get; set; }

        /// <summary>Required. The Merchant Center id of the merchant to submit the store for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAccount")]
        public virtual System.Nullable<long> TargetAccount { get; set; }

        /// <summary>Optional. The website URL for the store or merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUri")]
        public virtual string WebsiteUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListLfpStores method.</summary>
    public class ListLfpStoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The stores from the specified merchant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lfpStores")]
        public virtual System.Collections.Generic.IList<LfpStore> LfpStores { get; set; }

        /// <summary>
        /// A token, which can be sent as `pageToken` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The price represented as a number and currency.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The price represented as a number in micros (1 million micros is an equivalent to one's currency standard
        /// unit, for example, 1 USD = 1000000 micros).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("amountMicros")]
        public virtual System.Nullable<long> AmountMicros { get; set; }

        /// <summary>
        /// The currency of the price using three-letter acronyms according to [ISO
        /// 4217](http://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The change that happened to the product including old value, new value, country code as the region code and
    /// reporting context.
    /// </summary>
    public class ProductChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new value of the changed resource or attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual string NewValue { get; set; }

        /// <summary>The old value of the changed resource or attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldValue")]
        public virtual string OldValue { get; set; }

        /// <summary>Countries that have the change (if applicable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>Reporting contexts that have the change (if applicable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportingContext")]
        public virtual string ReportingContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message that the merchant will receive to notify about product status change event</summary>
    public class ProductStatusChangeMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The target account that owns the entity that changed. Format : `accounts/{merchant_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("account")]
        public virtual string Account { get; set; }

        /// <summary>The attribute in the resource that changed, in this case it will be always `Status`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual string Attribute { get; set; }

        /// <summary>A message to describe the change that happened to the product</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changes")]
        public virtual System.Collections.Generic.IList<ProductChange> Changes { get; set; }

        /// <summary>
        /// The account that manages the merchant's account. can be the same as merchant id if it is standalone account.
        /// Format : `accounts/{service_provider_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managingAccount")]
        public virtual string ManagingAccount { get; set; }

        /// <summary>The product name. Format: `{product.name=accounts/{account}/products/{product}}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The product id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The resource that changed, in this case it will always be `Product`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
