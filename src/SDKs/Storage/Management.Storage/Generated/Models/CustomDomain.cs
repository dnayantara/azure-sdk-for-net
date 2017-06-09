// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The custom domain assigned to this storage account. This can be set via
    /// Update.
    /// </summary>
    public partial class CustomDomain
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        /// <param name="name">Gets or sets the custom domain name assigned to
        /// the storage account. Name is the CNAME source.</param>
        /// <param name="useSubDomain">Indicates whether indirect CName
        /// validation is enabled. Default value is false. This should only be
        /// set on updates.</param>
        public CustomDomain(string name, bool? useSubDomain = default(bool?))
        {
            Name = name;
            UseSubDomain = useSubDomain;
        }

        /// <summary>
        /// Gets or sets the custom domain name assigned to the storage
        /// account. Name is the CNAME source.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets indicates whether indirect CName validation is
        /// enabled. Default value is false. This should only be set on
        /// updates.
        /// </summary>
        [JsonProperty(PropertyName = "useSubDomain")]
        public bool? UseSubDomain { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}

