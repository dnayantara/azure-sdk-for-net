// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Azure;
    using Management;
    using OperationalInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The status of the storage insight.
    /// </summary>
    public partial class StorageInsightStatus
    {
        /// <summary>
        /// Initializes a new instance of the StorageInsightStatus class.
        /// </summary>
        public StorageInsightStatus() { }

        /// <summary>
        /// Initializes a new instance of the StorageInsightStatus class.
        /// </summary>
        /// <param name="state">The state of the storage insight connection to
        /// the workspace. Possible values include: 'OK', 'ERROR'</param>
        /// <param name="description">Description of the state of the storage
        /// insight.</param>
        public StorageInsightStatus(string state, string description = default(string))
        {
            State = state;
            Description = description;
        }

        /// <summary>
        /// Gets or sets the state of the storage insight connection to the
        /// workspace. Possible values include: 'OK', 'ERROR'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets description of the state of the storage insight.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (State == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "State");
            }
        }
    }
}

