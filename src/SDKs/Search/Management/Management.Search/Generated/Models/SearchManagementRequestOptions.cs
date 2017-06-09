// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Search;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for a set of operations.
    /// </summary>
    public partial class SearchManagementRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the SearchManagementRequestOptions
        /// class.
        /// </summary>
        public SearchManagementRequestOptions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchManagementRequestOptions
        /// class.
        /// </summary>
        /// <param name="clientRequestId">A client-generated GUID value that
        /// identifies this request. If specified, this will be included in
        /// response information as a way to track the request.</param>
        public SearchManagementRequestOptions(System.Guid? clientRequestId = default(System.Guid?))
        {
            ClientRequestId = clientRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a client-generated GUID value that identifies this
        /// request. If specified, this will be included in response
        /// information as a way to track the request.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public System.Guid? ClientRequestId { get; set; }

    }
}
