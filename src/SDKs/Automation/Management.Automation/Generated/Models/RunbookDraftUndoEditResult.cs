// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The response model for the undoedit runbook operation.
    /// </summary>
    public partial class RunbookDraftUndoEditResult
    {
        /// <summary>
        /// Initializes a new instance of the RunbookDraftUndoEditResult class.
        /// </summary>
        public RunbookDraftUndoEditResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookDraftUndoEditResult class.
        /// </summary>
        /// <param name="statusCode">Possible values include: 'Continue',
        /// 'SwitchingProtocols', 'OK', 'Created', 'Accepted',
        /// 'NonAuthoritativeInformation', 'NoContent', 'ResetContent',
        /// 'PartialContent', 'MultipleChoices', 'Ambiguous',
        /// 'MovedPermanently', 'Moved', 'Found', 'Redirect', 'SeeOther',
        /// 'RedirectMethod', 'NotModified', 'UseProxy', 'Unused',
        /// 'TemporaryRedirect', 'RedirectKeepVerb', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable',
        /// 'GatewayTimeout', 'HttpVersionNotSupported'</param>
        public RunbookDraftUndoEditResult(HttpStatusCode? statusCode = default(HttpStatusCode?), string requestId = default(string))
        {
            StatusCode = statusCode;
            RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Continue',
        /// 'SwitchingProtocols', 'OK', 'Created', 'Accepted',
        /// 'NonAuthoritativeInformation', 'NoContent', 'ResetContent',
        /// 'PartialContent', 'MultipleChoices', 'Ambiguous',
        /// 'MovedPermanently', 'Moved', 'Found', 'Redirect', 'SeeOther',
        /// 'RedirectMethod', 'NotModified', 'UseProxy', 'Unused',
        /// 'TemporaryRedirect', 'RedirectKeepVerb', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable',
        /// 'GatewayTimeout', 'HttpVersionNotSupported'
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public HttpStatusCode? StatusCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

    }
}
