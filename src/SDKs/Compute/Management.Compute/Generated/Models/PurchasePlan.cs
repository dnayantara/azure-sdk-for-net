// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Used for establishing the purchase context of any 3rd Party artifact
    /// through MarketPlace.
    /// </summary>
    public partial class PurchasePlan
    {
        /// <summary>
        /// Initializes a new instance of the PurchasePlan class.
        /// </summary>
        public PurchasePlan() { }

        /// <summary>
        /// Initializes a new instance of the PurchasePlan class.
        /// </summary>
        /// <param name="publisher">The publisher ID.</param>
        /// <param name="name">The plan ID.</param>
        /// <param name="product">The product ID.</param>
        public PurchasePlan(string publisher, string name, string product)
        {
            Publisher = publisher;
            Name = name;
            Product = product;
        }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product ID.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Publisher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Publisher");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Product");
            }
        }
    }
}

