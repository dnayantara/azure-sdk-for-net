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
    /// The Metadata definition base.
    /// </summary>
    public partial class MetadataDefinitionBase
    {
        /// <summary>
        /// Initializes a new instance of the MetadataDefinitionBase class.
        /// </summary>
        public MetadataDefinitionBase()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataDefinitionBase class.
        /// </summary>
        /// <param name="attributes">The attributes for the Type.</param>
        /// <param name="description">Localized descriptions for the
        /// property.</param>
        /// <param name="displayName">Localized display names for the
        /// property.</param>
        /// <param name="localizedAttributes">Any custom localized attributes
        /// for the Type.</param>
        /// <param name="smallImage">Small Image associated with the Property
        /// or EntityType.</param>
        /// <param name="mediumImage">Medium Image associated with the Property
        /// or EntityType.</param>
        /// <param name="largeImage">Large Image associated with the Property
        /// or EntityType.</param>
        public MetadataDefinitionBase(IDictionary<string, IList<string>> attributes = default(IDictionary<string, IList<string>>), IDictionary<string, string> description = default(IDictionary<string, string>), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, IDictionary<string, string>> localizedAttributes = default(IDictionary<string, IDictionary<string, string>>), string smallImage = default(string), string mediumImage = default(string), string largeImage = default(string))
        {
            Attributes = attributes;
            Description = description;
            DisplayName = displayName;
            LocalizedAttributes = localizedAttributes;
            SmallImage = smallImage;
            MediumImage = mediumImage;
            LargeImage = largeImage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the attributes for the Type.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public IDictionary<string, IList<string>> Attributes { get; set; }

        /// <summary>
        /// Gets or sets localized descriptions for the property.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets localized display names for the property.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets any custom localized attributes for the Type.
        /// </summary>
        [JsonProperty(PropertyName = "localizedAttributes")]
        public IDictionary<string, IDictionary<string, string>> LocalizedAttributes { get; set; }

        /// <summary>
        /// Gets or sets small Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "smallImage")]
        public string SmallImage { get; set; }

        /// <summary>
        /// Gets or sets medium Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "mediumImage")]
        public string MediumImage { get; set; }

        /// <summary>
        /// Gets or sets large Image associated with the Property or
        /// EntityType.
        /// </summary>
        [JsonProperty(PropertyName = "largeImage")]
        public string LargeImage { get; set; }

    }
}
