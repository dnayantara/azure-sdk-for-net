// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Azure;
    using Management;
    using OperationalInsights;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The top level Linked service resource container.
    /// </summary>
    [JsonTransformation]
    public partial class LinkedService : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the LinkedService class.
        /// </summary>
        public LinkedService() { }

        /// <summary>
        /// Initializes a new instance of the LinkedService class.
        /// </summary>
        /// <param name="resourceId">The resource id of the resource that will
        /// be linked to the workspace.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags</param>
        public LinkedService(string resourceId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type, tags)
        {
            ResourceId = resourceId;
        }

        /// <summary>
        /// Gets or sets the resource id of the resource that will be linked to
        /// the workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
        }
    }
}

