// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using Azure;
    using Management;
    using Batch;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Create operation.
    /// </summary>
    public partial class BatchAccountCreateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateHeaders class.
        /// </summary>
        public BatchAccountCreateHeaders() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateHeaders class.
        /// </summary>
        /// <param name="location">The URL of the resource used to check the
        /// status of the asynchronous operation.</param>
        /// <param name="retryAfter">Suggested delay to check the status of the
        /// asynchronous operation. The value is an integer that specifies the
        /// delay in seconds.</param>
        public BatchAccountCreateHeaders(string location = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            RetryAfter = retryAfter;
        }

        /// <summary>
        /// Gets or sets the URL of the resource used to check the status of
        /// the asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets suggested delay to check the status of the
        /// asynchronous operation. The value is an integer that specifies the
        /// delay in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}

