// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Body of the error response returned from the API.
    /// </summary>
    public partial class ErrorEntity
    {
        /// <summary>
        /// Initializes a new instance of the ErrorEntity class.
        /// </summary>
        public ErrorEntity() { }

        /// <summary>
        /// Initializes a new instance of the ErrorEntity class.
        /// </summary>
        /// <param name="extendedCode">Type of error.</param>
        /// <param name="messageTemplate">Message template.</param>
        /// <param name="parameters">Parameters for the template.</param>
        /// <param name="innerErrors">Inner errors.</param>
        /// <param name="code">Basic error code.</param>
        /// <param name="message">Any details of the error.</param>
        public ErrorEntity(string extendedCode = default(string), string messageTemplate = default(string), IList<string> parameters = default(IList<string>), IList<ErrorEntity> innerErrors = default(IList<ErrorEntity>), string code = default(string), string message = default(string))
        {
            ExtendedCode = extendedCode;
            MessageTemplate = messageTemplate;
            Parameters = parameters;
            InnerErrors = innerErrors;
            Code = code;
            Message = message;
        }

        /// <summary>
        /// Gets or sets type of error.
        /// </summary>
        [JsonProperty(PropertyName = "extendedCode")]
        public string ExtendedCode { get; set; }

        /// <summary>
        /// Gets or sets message template.
        /// </summary>
        [JsonProperty(PropertyName = "messageTemplate")]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Gets or sets parameters for the template.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets inner errors.
        /// </summary>
        [JsonProperty(PropertyName = "innerErrors")]
        public IList<ErrorEntity> InnerErrors { get; set; }

        /// <summary>
        /// Gets or sets basic error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets any details of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}

