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
    /// The parameters schema of integration account map.
    /// </summary>
    public partial class IntegrationAccountMapPropertiesParametersSchema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationAccountMapPropertiesParametersSchema class.
        /// </summary>
        public IntegrationAccountMapPropertiesParametersSchema()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IntegrationAccountMapPropertiesParametersSchema class.
        /// </summary>
        /// <param name="refProperty">The reference name.</param>
        public IntegrationAccountMapPropertiesParametersSchema(string refProperty = default(string))
        {
            RefProperty = refProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference name.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string RefProperty { get; set; }

    }
}
