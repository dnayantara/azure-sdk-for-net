// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entity representing the reference to the template.
    /// </summary>
    public partial class TemplateLink
    {
        /// <summary>
        /// Initializes a new instance of the TemplateLink class.
        /// </summary>
        public TemplateLink()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateLink class.
        /// </summary>
        /// <param name="uri">The URI of the template to deploy.</param>
        /// <param name="contentVersion">If included, must match the
        /// ContentVersion in the template.</param>
        public TemplateLink(string uri, string contentVersion = default(string))
        {
            Uri = uri;
            ContentVersion = contentVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI of the template to deploy.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets if included, must match the ContentVersion in the
        /// template.
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
        }
    }
}
