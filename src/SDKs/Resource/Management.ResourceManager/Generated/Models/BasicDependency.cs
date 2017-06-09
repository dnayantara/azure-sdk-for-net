// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment dependency information.
    /// </summary>
    public partial class BasicDependency
    {
        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        public BasicDependency()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        /// <param name="id">The ID of the dependency.</param>
        /// <param name="resourceType">The dependency resource type.</param>
        /// <param name="resourceName">The dependency resource name.</param>
        public BasicDependency(string id = default(string), string resourceType = default(string), string resourceName = default(string))
        {
            Id = id;
            ResourceType = resourceType;
            ResourceName = resourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the dependency.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource name.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

    }
}
