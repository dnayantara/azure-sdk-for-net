// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The KPI participant profile metadata.
    /// </summary>
    public partial class KpiParticipantProfilesMetadata
    {
        /// <summary>
        /// Initializes a new instance of the KpiParticipantProfilesMetadata
        /// class.
        /// </summary>
        public KpiParticipantProfilesMetadata()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KpiParticipantProfilesMetadata
        /// class.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        public KpiParticipantProfilesMetadata(string typeName)
        {
            TypeName = typeName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the type.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TypeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeName");
            }
        }
    }
}
