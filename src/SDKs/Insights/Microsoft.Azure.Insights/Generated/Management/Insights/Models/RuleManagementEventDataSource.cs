// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rule management event data source. The discriminator fields is always
    /// RuleManagementEventDataSource in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource")]
    public partial class RuleManagementEventDataSource : RuleDataSource
    {
        /// <summary>
        /// Initializes a new instance of the RuleManagementEventDataSource
        /// class.
        /// </summary>
        public RuleManagementEventDataSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RuleManagementEventDataSource
        /// class.
        /// </summary>
        /// <param name="eventName">the event name.</param>
        /// <param name="eventSource">the event source.</param>
        /// <param name="level">the level.</param>
        /// <param name="operationName">The name of the operation that should
        /// be checked for. If no name is provided, any operation will
        /// match.</param>
        /// <param name="resourceGroupName">the resource group name.</param>
        /// <param name="resourceProviderName">the resource provider
        /// name.</param>
        /// <param name="resourceUri">the resource uri.</param>
        /// <param name="status">The status of the operation that should be
        /// checked for. If no status is provided, any status will
        /// match.</param>
        /// <param name="subStatus">the substatus.</param>
        /// <param name="claims">the claims.</param>
        public RuleManagementEventDataSource(string eventName = default(string), string eventSource = default(string), string level = default(string), string operationName = default(string), string resourceGroupName = default(string), string resourceProviderName = default(string), string resourceUri = default(string), string status = default(string), string subStatus = default(string), RuleManagementEventClaimsDataSource claims = default(RuleManagementEventClaimsDataSource))
        {
            EventName = eventName;
            EventSource = eventSource;
            Level = level;
            OperationName = operationName;
            ResourceGroupName = resourceGroupName;
            ResourceProviderName = resourceProviderName;
            ResourceUri = resourceUri;
            Status = status;
            SubStatus = subStatus;
            Claims = claims;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the event name.
        /// </summary>
        [JsonProperty(PropertyName = "eventName")]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the event source.
        /// </summary>
        [JsonProperty(PropertyName = "eventSource")]
        public string EventSource { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the name of the operation that should be checked for.
        /// If no name is provided, any operation will match.
        /// </summary>
        [JsonProperty(PropertyName = "operationName")]
        public string OperationName { get; set; }

        /// <summary>
        /// Gets or sets the resource group name.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the resource provider name.
        /// </summary>
        [JsonProperty(PropertyName = "resourceProviderName")]
        public string ResourceProviderName { get; set; }

        /// <summary>
        /// Gets or sets the resource uri.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or sets the status of the operation that should be checked
        /// for. If no status is provided, any status will match.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the substatus.
        /// </summary>
        [JsonProperty(PropertyName = "subStatus")]
        public string SubStatus { get; set; }

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        [JsonProperty(PropertyName = "claims")]
        public RuleManagementEventClaimsDataSource Claims { get; set; }

    }
}
