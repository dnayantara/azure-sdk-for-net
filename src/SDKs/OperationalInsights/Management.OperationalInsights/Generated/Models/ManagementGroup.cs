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
    using System.Linq;

    /// <summary>
    /// A management group that is connected to a workspace
    /// </summary>
    [JsonTransformation]
    public partial class ManagementGroup
    {
        /// <summary>
        /// Initializes a new instance of the ManagementGroup class.
        /// </summary>
        public ManagementGroup() { }

        /// <summary>
        /// Initializes a new instance of the ManagementGroup class.
        /// </summary>
        /// <param name="serverCount">The number of servers connected to the
        /// management group.</param>
        /// <param name="isGateway">Gets or sets a value indicating whether the
        /// management group is a gateway.</param>
        /// <param name="name">The name of the management group.</param>
        /// <param name="id">The unique ID of the management group.</param>
        /// <param name="created">The datetime that the management group was
        /// created.</param>
        /// <param name="dataReceived">The last datetime that the management
        /// group received data.</param>
        /// <param name="version">The version of System Center that is managing
        /// the management group.</param>
        /// <param name="sku">The SKU of System Center that is managing the
        /// management group.</param>
        public ManagementGroup(int? serverCount = default(int?), bool? isGateway = default(bool?), string name = default(string), string id = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? dataReceived = default(System.DateTime?), string version = default(string), string sku = default(string))
        {
            ServerCount = serverCount;
            IsGateway = isGateway;
            Name = name;
            Id = id;
            Created = created;
            DataReceived = dataReceived;
            Version = version;
            Sku = sku;
        }

        /// <summary>
        /// Gets or sets the number of servers connected to the management
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverCount")]
        public int? ServerCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the management group is a
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isGateway")]
        public bool? IsGateway { get; set; }

        /// <summary>
        /// Gets or sets the name of the management group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique ID of the management group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the datetime that the management group was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the last datetime that the management group received
        /// data.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataReceived")]
        public System.DateTime? DataReceived { get; set; }

        /// <summary>
        /// Gets or sets the version of System Center that is managing the
        /// management group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the SKU of System Center that is managing the
        /// management group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; set; }

    }
}

