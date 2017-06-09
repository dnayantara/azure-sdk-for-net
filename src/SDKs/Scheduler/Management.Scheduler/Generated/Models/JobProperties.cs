// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        /// <param name="startTime">Gets or sets the job start time.</param>
        /// <param name="action">Gets or sets the job action.</param>
        /// <param name="recurrence">Gets or sets the job recurrence.</param>
        /// <param name="state">Gets or set the job state. Possible values
        /// include: 'Enabled', 'Disabled', 'Faulted', 'Completed'</param>
        /// <param name="status">Gets the job status.</param>
        public JobProperties(System.DateTime? startTime = default(System.DateTime?), JobAction action = default(JobAction), JobRecurrence recurrence = default(JobRecurrence), JobState? state = default(JobState?), JobStatus status = default(JobStatus))
        {
            StartTime = startTime;
            Action = action;
            Recurrence = recurrence;
            State = state;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the job action.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public JobAction Action { get; set; }

        /// <summary>
        /// Gets or sets the job recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "recurrence")]
        public JobRecurrence Recurrence { get; set; }

        /// <summary>
        /// Gets or set the job state. Possible values include: 'Enabled',
        /// 'Disabled', 'Faulted', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets the job status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public JobStatus Status { get; private set; }

    }
}
