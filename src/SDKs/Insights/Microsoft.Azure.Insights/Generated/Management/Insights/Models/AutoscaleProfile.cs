// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Autoscale profile.
    /// </summary>
    public partial class AutoscaleProfile
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleProfile class.
        /// </summary>
        public AutoscaleProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleProfile class.
        /// </summary>
        /// <param name="name">the name of the profile.</param>
        /// <param name="capacity">the number of instances that can be used
        /// during this profile.</param>
        /// <param name="rules">the collection of rules that provide the
        /// triggers and parameters for the scaling action. A maximum of 10
        /// rules can be specified.</param>
        /// <param name="fixedDate">the specific date-time for the profile.
        /// This element is not used if the Recurrence element is used.</param>
        /// <param name="recurrence">the repeating times at which this profile
        /// begins. This element is not used if the FixedDate element is
        /// used.</param>
        public AutoscaleProfile(string name, ScaleCapacity capacity, IList<ScaleRule> rules, TimeWindow fixedDate = default(TimeWindow), Recurrence recurrence = default(Recurrence))
        {
            Name = name;
            Capacity = capacity;
            Rules = rules;
            FixedDate = fixedDate;
            Recurrence = recurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the number of instances that can be used during this
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public ScaleCapacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets the collection of rules that provide the triggers and
        /// parameters for the scaling action. A maximum of 10 rules can be
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ScaleRule> Rules { get; set; }

        /// <summary>
        /// Gets or sets the specific date-time for the profile. This element
        /// is not used if the Recurrence element is used.
        /// </summary>
        [JsonProperty(PropertyName = "fixedDate")]
        public TimeWindow FixedDate { get; set; }

        /// <summary>
        /// Gets or sets the repeating times at which this profile begins. This
        /// element is not used if the FixedDate element is used.
        /// </summary>
        [JsonProperty(PropertyName = "recurrence")]
        public Recurrence Recurrence { get; set; }

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
            if (Capacity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Capacity");
            }
            if (Rules == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rules");
            }
            if (Capacity != null)
            {
                Capacity.Validate();
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (FixedDate != null)
            {
                FixedDate.Validate();
            }
            if (Recurrence != null)
            {
                Recurrence.Validate();
            }
        }
    }
}
