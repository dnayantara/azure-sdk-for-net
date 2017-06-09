// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.PowerBIEmbedded;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CreateWorkspaceCollectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        public CreateWorkspaceCollectionRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        /// <param name="location">Azure location</param>
        public CreateWorkspaceCollectionRequest(string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CreateWorkspaceCollectionRequest class.
        /// </summary>
        static CreateWorkspaceCollectionRequest()
        {
            Sku = new AzureSku();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public static AzureSku Sku { get; private set; }

    }
}
