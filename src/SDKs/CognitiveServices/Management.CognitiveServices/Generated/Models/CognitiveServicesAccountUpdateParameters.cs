// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CognitiveServices;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    public partial class CognitiveServicesAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountUpdateParameters class.
        /// </summary>
        public CognitiveServicesAccountUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CognitiveServicesAccountUpdateParameters class.
        /// </summary>
        /// <param name="sku">Gets or sets the SKU of the resource.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater than 128 characters and value no greater than 256
        /// characters.</param>
        public CognitiveServicesAccountUpdateParameters(Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key no greater than 128 characters
        /// and value no greater than 256 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
