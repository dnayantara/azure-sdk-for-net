// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Intune;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Android Policy request body for Intune MAM.
    /// </summary>
    public partial class MAMPolicyAppOrGroupIdProperties
    {
        /// <summary>
        /// Initializes a new instance of the MAMPolicyAppOrGroupIdProperties
        /// class.
        /// </summary>
        public MAMPolicyAppOrGroupIdProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MAMPolicyAppOrGroupIdProperties
        /// class.
        /// </summary>
        public MAMPolicyAppOrGroupIdProperties(string url)
        {
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
