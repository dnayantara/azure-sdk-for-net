// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The KPI GroupBy field metadata.
    /// </summary>
    public partial class KpiGroupByMetadata
    {
        /// <summary>
        /// Initializes a new instance of the KpiGroupByMetadata class.
        /// </summary>
        public KpiGroupByMetadata()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KpiGroupByMetadata class.
        /// </summary>
        /// <param name="displayName">The display name.</param>
        /// <param name="fieldName">The name of the field.</param>
        /// <param name="fieldType">The type of the field.</param>
        public KpiGroupByMetadata(IDictionary<string, string> displayName = default(IDictionary<string, string>), string fieldName = default(string), string fieldType = default(string))
        {
            DisplayName = displayName;
            FieldName = fieldName;
            FieldType = fieldType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        [JsonProperty(PropertyName = "fieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or sets the type of the field.
        /// </summary>
        [JsonProperty(PropertyName = "fieldType")]
        public string FieldType { get; set; }

    }
}
