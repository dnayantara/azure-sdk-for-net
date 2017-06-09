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

    public partial class WorkspaceCollection
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceCollection class.
        /// </summary>
        public WorkspaceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceCollection class.
        /// </summary>
        /// <param name="id">Resource id</param>
        /// <param name="name">Workspace collection name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Azure location</param>
        /// <param name="properties">Properties</param>
        public WorkspaceCollection(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), object properties = default(object))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Properties = properties;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for WorkspaceCollection class.
        /// </summary>
        static WorkspaceCollection()
        {
            Sku = new AzureSku();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets workspace collection name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

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
        /// Gets or sets properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public static AzureSku Sku { get; private set; }

    }
}
