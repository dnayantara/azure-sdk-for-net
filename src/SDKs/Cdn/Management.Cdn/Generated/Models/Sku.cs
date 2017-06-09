// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The pricing tier (defines a CDN provider, feature list and rate) of the
    /// CDN profile.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">Name of the pricing tier. Possible values
        /// include: 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'</param>
        public Sku(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets name of the pricing tier. Possible values include:
        /// 'Standard_Verizon', 'Premium_Verizon', 'Custom_Verizon',
        /// 'Standard_Akamai', 'Standard_ChinaCdn'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}

