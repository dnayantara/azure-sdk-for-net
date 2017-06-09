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
    /// Resource link filter.
    /// </summary>
    public partial class ResourceLinkFilter
    {
        /// <summary>
        /// Initializes a new instance of the ResourceLinkFilter class.
        /// </summary>
        public ResourceLinkFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceLinkFilter class.
        /// </summary>
        /// <param name="targetId">The ID of the target resource.</param>
        public ResourceLinkFilter(string targetId)
        {
            TargetId = targetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the target resource.
        /// </summary>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetId");
            }
        }
    }
}
