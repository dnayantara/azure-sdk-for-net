// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network interface and its custom security rules.
    /// </summary>
    public partial class NetworkInterfaceAssociation
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceAssociation
        /// class.
        /// </summary>
        public NetworkInterfaceAssociation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceAssociation
        /// class.
        /// </summary>
        /// <param name="id">Network interface ID.</param>
        /// <param name="securityRules">Collection of custom security
        /// rules.</param>
        public NetworkInterfaceAssociation(string id = default(string), IList<SecurityRule> securityRules = default(IList<SecurityRule>))
        {
            Id = id;
            SecurityRules = securityRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets network interface ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets collection of custom security rules.
        /// </summary>
        [JsonProperty(PropertyName = "securityRules")]
        public IList<SecurityRule> SecurityRules { get; set; }

    }
}
