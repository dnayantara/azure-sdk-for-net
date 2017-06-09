// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create job schedule operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobScheduleCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleCreateParameters
        /// class.
        /// </summary>
        public JobScheduleCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobScheduleCreateParameters
        /// class.
        /// </summary>
        /// <param name="schedule">Gets or sets the schedule.</param>
        /// <param name="runbook">Gets or sets the runbook.</param>
        /// <param name="runOn">Gets or sets the hybrid worker group that the
        /// scheduled job should run on.</param>
        /// <param name="parameters">Gets or sets a list of job
        /// properties.</param>
        public JobScheduleCreateParameters(ScheduleAssociationProperty schedule, RunbookAssociationProperty runbook, string runOn = default(string), IDictionary<string, string> parameters = default(IDictionary<string, string>))
        {
            Schedule = schedule;
            Runbook = runbook;
            RunOn = runOn;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schedule")]
        public ScheduleAssociationProperty Schedule { get; set; }

        /// <summary>
        /// Gets or sets the runbook.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runbook")]
        public RunbookAssociationProperty Runbook { get; set; }

        /// <summary>
        /// Gets or sets the hybrid worker group that the scheduled job should
        /// run on.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Gets or sets a list of job properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (Runbook == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Runbook");
            }
        }
    }
}
