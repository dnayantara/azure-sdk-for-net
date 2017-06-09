// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Storage blob container information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageContainer
    {
        /// <summary>
        /// Initializes a new instance of the StorageContainer class.
        /// </summary>
        public StorageContainer()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageContainer class.
        /// </summary>
        /// <param name="name">the name of the blob container.</param>
        /// <param name="id">the unique identifier of the blob
        /// container.</param>
        /// <param name="type">the type of the blob container.</param>
        /// <param name="lastModifiedTime">the last modified time of the blob
        /// container.</param>
        public StorageContainer(string name = default(string), string id = default(string), string type = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?))
        {
            Name = name;
            Id = id;
            Type = type;
            LastModifiedTime = lastModifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the unique identifier of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the last modified time of the blob container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

    }
}
