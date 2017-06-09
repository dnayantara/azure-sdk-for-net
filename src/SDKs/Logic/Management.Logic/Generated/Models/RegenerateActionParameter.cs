// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The access key regenerate action content.
    /// </summary>
    public partial class RegenerateActionParameter
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateActionParameter class.
        /// </summary>
        public RegenerateActionParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateActionParameter class.
        /// </summary>
        /// <param name="keyType">The key type. Possible values include:
        /// 'NotSpecified', 'Primary', 'Secondary'</param>
        public RegenerateActionParameter(KeyType? keyType = default(KeyType?))
        {
            KeyType = keyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key type. Possible values include: 'NotSpecified',
        /// 'Primary', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public KeyType? KeyType { get; set; }

    }
}
