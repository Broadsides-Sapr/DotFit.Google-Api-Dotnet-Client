// Copyright 2021 Google LLC
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

namespace Google.Apis.Speech.v1
{
    /// <summary>The Speech Service.</summary>
    public class SpeechService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SpeechService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SpeechService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
            Speech = new SpeechResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "speech";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://speech.googleapis.com/";
        #else
            "https://speech.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://speech.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Speech-to-Text API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Speech-to-Text API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Speech resource.</summary>
        public virtual SpeechResource Speech { get; }
    }

    /// <summary>A base abstract class for Speech requests.</summary>
    public abstract class SpeechBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SpeechBaseServiceRequest instance.</summary>
        protected SpeechBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Speech parameter list.</summary>
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

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/operations/{+name}";

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
                    Pattern = @"^.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The standard list filter.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The name of the operation's parent resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>The standard list page size.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The standard list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
    }

    /// <summary>The "speech" collection of methods.</summary>
    public class SpeechResource
    {
        private const string Resource = "speech";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpeechResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the google.longrunning.Operations interface.
        /// Returns either an `Operation.error` or an `Operation.response` which contains a
        /// `LongRunningRecognizeResponse` message. For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual LongrunningrecognizeRequest Longrunningrecognize(Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest body)
        {
            return new LongrunningrecognizeRequest(service, body);
        }

        /// <summary>
        /// Performs asynchronous speech recognition: receive results via the google.longrunning.Operations interface.
        /// Returns either an `Operation.error` or an `Operation.response` which contains a
        /// `LongRunningRecognizeResponse` message. For more information on asynchronous speech recognition, see the
        /// [how-to](https://cloud.google.com/speech-to-text/docs/async-recognize).
        /// </summary>
        public class LongrunningrecognizeRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.Operation>
        {
            /// <summary>Constructs a new Longrunningrecognize request.</summary>
            public LongrunningrecognizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Speech.v1.Data.LongRunningRecognizeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "longrunningrecognize";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/speech:longrunningrecognize";

            /// <summary>Initializes Longrunningrecognize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio has been sent and processed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual RecognizeRequest Recognize(Google.Apis.Speech.v1.Data.RecognizeRequest body)
        {
            return new RecognizeRequest(service, body);
        }

        /// <summary>
        /// Performs synchronous speech recognition: receive results after all audio has been sent and processed.
        /// </summary>
        public class RecognizeRequest : SpeechBaseServiceRequest<Google.Apis.Speech.v1.Data.RecognizeResponse>
        {
            /// <summary>Constructs a new Recognize request.</summary>
            public RecognizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Speech.v1.Data.RecognizeRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Speech.v1.Data.RecognizeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "recognize";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/speech:recognize";

            /// <summary>Initializes Recognize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.Speech.v1.Data
{
    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes the progress of a long-running `LongRunningRecognize` call. It is included in the `metadata` field of
    /// the `Operation` returned by the `GetOperation` call of the `google::longrunning::Operations` service.
    /// </summary>
    public class LongRunningRecognizeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time of the most recent processing update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; }

        /// <summary>
        /// Approximate percentage of audio processed thus far. Guaranteed to be 100 when the audio is fully processed
        /// and the results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("progressPercent")]
        public virtual System.Nullable<int> ProgressPercent { get; set; }

        /// <summary>Time when the request was received.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Output only. The URI of the audio file being transcribed. Empty if the audio was sent as byte content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The top-level message sent by the client for the `LongRunningRecognize` method.</summary>
    public class LongRunningRecognizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The audio data to be recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual RecognitionAudio Audio { get; set; }

        /// <summary>
        /// Required. Provides information to the recognizer that specifies how to process the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual RecognitionConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The only message returned to the client by the `LongRunningRecognize` method. It contains the result as zero or
    /// more sequential `SpeechRecognitionResult` messages. It is included in the `result.response` field of the
    /// `Operation` returned by the `GetOperation` call of the `google::longrunning::Operations` service.
    /// </summary>
    public class LongRunningRecognizeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sequential list of transcription results corresponding to sequential portions of audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<SpeechRecognitionResult> Results { get; set; }

        /// <summary>When available, billed audio seconds for the corresponding request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBilledTime")]
        public virtual object TotalBilledTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains audio data in the encoding specified in the `RecognitionConfig`. Either `content` or `uri` must be
    /// supplied. Supplying both or neither returns google.rpc.Code.INVALID_ARGUMENT. See [content
    /// limits](https://cloud.google.com/speech-to-text/quotas#content).
    /// </summary>
    public class RecognitionAudio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The audio data bytes encoded as specified in `RecognitionConfig`. Note: as with all bytes fields, proto
        /// buffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>
        /// URI that points to a file that contains audio data bytes as specified in `RecognitionConfig`. The file must
        /// not be compressed (for example, gzip). Currently, only Google Cloud Storage URIs are supported, which must
        /// be specified in the following format: `gs://bucket_name/object_name` (other URI formats return
        /// google.rpc.Code.INVALID_ARGUMENT). For more information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides information to the recognizer that specifies how to process the request.</summary>
    public class RecognitionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of channels in the input audio data. ONLY set this for MULTI-CHANNEL recognition. Valid values
        /// for LINEAR16 and FLAC are `1`-`8`. Valid values for OGG_OPUS are '1'-'254'. Valid value for MULAW, AMR,
        /// AMR_WB and SPEEX_WITH_HEADER_BYTE is only `1`. If `0` or omitted, defaults to one channel (mono). Note: We
        /// only recognize the first channel by default. To perform independent recognition on each channel set
        /// `enable_separate_recognition_per_channel` to 'true'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioChannelCount")]
        public virtual System.Nullable<int> AudioChannelCount { get; set; }

        /// <summary>
        /// Config to enable speaker diarization and set additional parameters to make diarization better suited for
        /// your application. Note: When this is enabled, we send all the words from the beginning of the audio for the
        /// top alternative in every consecutive STREAMING responses. This is done in order to improve our speaker tags
        /// as our models learn to identify the speakers in the conversation over time. For non-streaming requests, the
        /// diarization results will be provided only in the top alternative of the FINAL SpeechRecognitionResult.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diarizationConfig")]
        public virtual SpeakerDiarizationConfig DiarizationConfig { get; set; }

        /// <summary>
        /// If 'true', adds punctuation to recognition result hypotheses. This feature is only available in select
        /// languages. Setting this for requests in other languages has no effect at all. The default 'false' value does
        /// not add punctuation to result hypotheses.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutomaticPunctuation")]
        public virtual System.Nullable<bool> EnableAutomaticPunctuation { get; set; }

        /// <summary>
        /// This needs to be set to `true` explicitly and `audio_channel_count` &amp;gt; 1 to get each channel
        /// recognized separately. The recognition result will contain a `channel_tag` field to state which channel that
        /// result belongs to. If this is not true, we will only recognize the first channel. The request is billed
        /// cumulatively for all channels recognized: `audio_channel_count` multiplied by the length of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSeparateRecognitionPerChannel")]
        public virtual System.Nullable<bool> EnableSeparateRecognitionPerChannel { get; set; }

        /// <summary>
        /// If `true`, the top result includes a list of words and the start and end time offsets (timestamps) for those
        /// words. If `false`, no word-level time offset information is returned. The default is `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWordTimeOffsets")]
        public virtual System.Nullable<bool> EnableWordTimeOffsets { get; set; }

        /// <summary>
        /// Encoding of audio data sent in all `RecognitionAudio` messages. This field is optional for `FLAC` and `WAV`
        /// audio files and required for all other audio formats. For details, see AudioEncoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encoding")]
        public virtual string Encoding { get; set; }

        /// <summary>
        /// Required. The language of the supplied audio as a [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt)
        /// language tag. Example: "en-US". See [Language
        /// Support](https://cloud.google.com/speech-to-text/docs/languages) for a list of the currently supported
        /// language codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Maximum number of recognition hypotheses to be returned. Specifically, the maximum number of
        /// `SpeechRecognitionAlternative` messages within each `SpeechRecognitionResult`. The server may return fewer
        /// than `max_alternatives`. Valid values are `0`-`30`. A value of `0` or `1` will return a maximum of one. If
        /// omitted, will return a maximum of one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAlternatives")]
        public virtual System.Nullable<int> MaxAlternatives { get; set; }

        /// <summary>Metadata regarding this request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual RecognitionMetadata Metadata { get; set; }

        /// <summary>
        /// Which model to select for the given request. Select the model best suited to your domain to get best
        /// results. If a model is not explicitly specified, then we auto-select a model based on the parameters in the
        /// RecognitionConfig. *Model* *Description* command_and_search Best for short queries such as voice commands or
        /// voice search. phone_call Best for audio that originated from a phone call (typically recorded at an 8khz
        /// sampling rate). video Best for audio that originated from video or includes multiple speakers. Ideally the
        /// audio is recorded at a 16khz or greater sampling rate. This is a premium model that costs more than the
        /// standard rate. default Best for audio that is not one of the specific audio models. For example, long-form
        /// audio. Ideally the audio is high-fidelity, recorded at a 16khz or greater sampling rate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>
        /// If set to `true`, the server will attempt to filter out profanities, replacing all but the initial character
        /// in each filtered word with asterisks, e.g. "f***". If set to `false` or omitted, profanities won't be
        /// filtered out.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profanityFilter")]
        public virtual System.Nullable<bool> ProfanityFilter { get; set; }

        /// <summary>
        /// Sample rate in Hertz of the audio data sent in all `RecognitionAudio` messages. Valid values are:
        /// 8000-48000. 16000 is optimal. For best results, set the sampling rate of the audio source to 16000 Hz. If
        /// that's not possible, use the native sample rate of the audio source (instead of re-sampling). This field is
        /// optional for FLAC and WAV audio files, but is required for all other audio formats. For details, see
        /// AudioEncoding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>
        /// Array of SpeechContext. A means to provide context to assist the speech recognition. For more information,
        /// see [speech adaptation](https://cloud.google.com/speech-to-text/docs/adaptation).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechContexts")]
        public virtual System.Collections.Generic.IList<SpeechContext> SpeechContexts { get; set; }

        /// <summary>
        /// Set to true to use an enhanced model for speech recognition. If `use_enhanced` is set to true and the
        /// `model` field is not set, then an appropriate enhanced model is chosen if an enhanced model exists for the
        /// audio. If `use_enhanced` is true and an enhanced version of the specified model does not exist, then the
        /// speech is recognized using the standard version of the specified model.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useEnhanced")]
        public virtual System.Nullable<bool> UseEnhanced { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of audio data to be recognized.</summary>
    public class RecognitionMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the content. Eg. "Recordings of federal supreme court hearings from 2012".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioTopic")]
        public virtual string AudioTopic { get; set; }

        /// <summary>
        /// The industry vertical to which this speech recognition request most closely applies. This is most indicative
        /// of the topics contained in the audio. Use the 6-digit NAICS code to identify the industry vertical - see
        /// https://www.naics.com/search/.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("industryNaicsCodeOfAudio")]
        public virtual System.Nullable<long> IndustryNaicsCodeOfAudio { get; set; }

        /// <summary>The use case most closely describing the audio content to be recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interactionType")]
        public virtual string InteractionType { get; set; }

        /// <summary>The audio type that most closely describes the audio being recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("microphoneDistance")]
        public virtual string MicrophoneDistance { get; set; }

        /// <summary>The original media the speech was recorded on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalMediaType")]
        public virtual string OriginalMediaType { get; set; }

        /// <summary>
        /// Mime type of the original audio file. For example `audio/m4a`, `audio/x-alaw-basic`, `audio/mp3`,
        /// `audio/3gpp`. A list of possible audio mime types is maintained at
        /// http://www.iana.org/assignments/media-types/media-types.xhtml#audio
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalMimeType")]
        public virtual string OriginalMimeType { get; set; }

        /// <summary>
        /// The device used to make the recording. Examples 'Nexus 5X' or 'Polycom SoundStation IP 6000' or 'POTS' or
        /// 'VoIP' or 'Cardioid Microphone'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingDeviceName")]
        public virtual string RecordingDeviceName { get; set; }

        /// <summary>The type of device the speech was recorded with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordingDeviceType")]
        public virtual string RecordingDeviceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The top-level message sent by the client for the `Recognize` method.</summary>
    public class RecognizeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The audio data to be recognized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual RecognitionAudio Audio { get; set; }

        /// <summary>
        /// Required. Provides information to the recognizer that specifies how to process the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual RecognitionConfig Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The only message returned to the client by the `Recognize` method. It contains the result as zero or more
    /// sequential `SpeechRecognitionResult` messages.
    /// </summary>
    public class RecognizeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Sequential list of transcription results corresponding to sequential portions of audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<SpeechRecognitionResult> Results { get; set; }

        /// <summary>When available, billed audio seconds for the corresponding request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBilledTime")]
        public virtual object TotalBilledTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Config to enable speaker diarization.</summary>
    public class SpeakerDiarizationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If 'true', enables speaker detection for each recognized word in the top alternative of the recognition
        /// result using a speaker_tag provided in the WordInfo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSpeakerDiarization")]
        public virtual System.Nullable<bool> EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// Maximum number of speakers in the conversation. This range gives you more flexibility by allowing the system
        /// to automatically determine the correct number of speakers. If not set, the default value is 6.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSpeakerCount")]
        public virtual System.Nullable<int> MaxSpeakerCount { get; set; }

        /// <summary>
        /// Minimum number of speakers in the conversation. This range gives you more flexibility by allowing the system
        /// to automatically determine the correct number of speakers. If not set, the default value is 2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minSpeakerCount")]
        public virtual System.Nullable<int> MinSpeakerCount { get; set; }

        /// <summary>Output only. Unused.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides "hints" to the speech recognizer to favor specific words and phrases in the results.</summary>
    public class SpeechContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of strings containing words and phrases "hints" so that the speech recognition is more likely to
        /// recognize them. This can be used to improve the accuracy for specific words and phrases, for example, if
        /// specific commands are typically spoken by the user. This can also be used to add additional words to the
        /// vocabulary of the recognizer. See [usage limits](https://cloud.google.com/speech-to-text/quotas#content).
        /// List items can also be set to classes for groups of words that represent common concepts that occur in
        /// natural language. For example, rather than providing phrase hints for every month of the year, using the
        /// $MONTH class improves the likelihood of correctly transcribing audio that includes months.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phrases")]
        public virtual System.Collections.Generic.IList<string> Phrases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Alternative hypotheses (a.k.a. n-best list).</summary>
    public class SpeechRecognitionAlternative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The confidence estimate between 0.0 and 1.0. A higher number indicates an estimated greater likelihood that
        /// the recognized words are correct. This field is set only for the top alternative of a non-streaming result
        /// or, of a streaming result where `is_final=true`. This field is not guaranteed to be accurate and users
        /// should not rely on it to be always provided. The default of 0.0 is a sentinel value indicating `confidence`
        /// was not set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; }

        /// <summary>Transcript text representing the words that the user spoke.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; }

        /// <summary>
        /// A list of word-specific information for each recognized word. Note: When `enable_speaker_diarization` is
        /// true, you will see all the words from the beginning of the audio.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<WordInfo> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A speech recognition result corresponding to a portion of the audio.</summary>
    public class SpeechRecognitionResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// May contain one or more recognition hypotheses (up to the maximum specified in `max_alternatives`). These
        /// alternatives are ordered in terms of accuracy, with the top (first) alternative being the most probable, as
        /// ranked by the recognizer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<SpeechRecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// For multi-channel audio, this is the channel number corresponding to the recognized result for the audio
        /// from that channel. For audio_channel_count = N, its output values can range from '1' to 'N'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("channelTag")]
        public virtual System.Nullable<int> ChannelTag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Word-specific information for recognized words.</summary>
    public class WordInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the end of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Output only. A distinct integer value is assigned for every speaker within the audio. This field specifies
        /// which one of those speakers was detected to have spoken this word. Value ranges from '1' to
        /// diarization_speaker_count. speaker_tag is set if enable_speaker_diarization = 'true' and only in the top
        /// alternative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakerTag")]
        public virtual System.Nullable<int> SpeakerTag { get; set; }

        /// <summary>
        /// Time offset relative to the beginning of the audio, and corresponding to the start of the spoken word. This
        /// field is only set if `enable_word_time_offsets=true` and only in the top hypothesis. This is an experimental
        /// feature and the accuracy of the time offset can vary.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The word corresponding to this set of information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("word")]
        public virtual string Word { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
