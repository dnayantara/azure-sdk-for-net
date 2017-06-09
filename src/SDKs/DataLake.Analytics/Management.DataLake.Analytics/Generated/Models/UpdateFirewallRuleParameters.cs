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
    /// Data Lake Analytics firewall rule update parameters
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdateFirewallRuleParameters
    {
        /// <summary>
        /// Initializes a new instance of the UpdateFirewallRuleParameters
        /// class.
        /// </summary>
        public UpdateFirewallRuleParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateFirewallRuleParameters
        /// class.
        /// </summary>
        /// <param name="startIpAddress">the start IP address for the firewall
        /// rule. This can be either ipv4 or ipv6. Start and End should be in
        /// the same protocol.</param>
        /// <param name="endIpAddress">the end IP address for the firewall
        /// rule. This can be either ipv4 or ipv6. Start and End should be in
        /// the same protocol.</param>
        public UpdateFirewallRuleParameters(string startIpAddress = default(string), string endIpAddress = default(string))
        {
            StartIpAddress = startIpAddress;
            EndIpAddress = endIpAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start IP address for the firewall rule. This can
        /// be either ipv4 or ipv6. Start and End should be in the same
        /// protocol.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startIpAddress")]
        public string StartIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the end IP address for the firewall rule. This can be
        /// either ipv4 or ipv6. Start and End should be in the same protocol.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endIpAddress")]
        public string EndIpAddress { get; set; }

    }
}
