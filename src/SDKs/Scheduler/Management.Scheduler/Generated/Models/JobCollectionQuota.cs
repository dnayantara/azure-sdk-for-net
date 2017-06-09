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

    public partial class JobCollectionQuota
    {
        /// <summary>
        /// Initializes a new instance of the JobCollectionQuota class.
        /// </summary>
        public JobCollectionQuota()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobCollectionQuota class.
        /// </summary>
        /// <param name="maxJobCount">Gets or set the maximum job
        /// count.</param>
        /// <param name="maxJobOccurrence">Gets or sets the maximum job
        /// occurrence.</param>
        /// <param name="maxRecurrence">Gets or set the maximum
        /// recurrence.</param>
        public JobCollectionQuota(int? maxJobCount = default(int?), int? maxJobOccurrence = default(int?), JobMaxRecurrence maxRecurrence = default(JobMaxRecurrence))
        {
            MaxJobCount = maxJobCount;
            MaxJobOccurrence = maxJobOccurrence;
            MaxRecurrence = maxRecurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or set the maximum job count.
        /// </summary>
        [JsonProperty(PropertyName = "maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum job occurrence.
        /// </summary>
        [JsonProperty(PropertyName = "maxJobOccurrence")]
        public int? MaxJobOccurrence { get; set; }

        /// <summary>
        /// Gets or set the maximum recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "maxRecurrence")]
        public JobMaxRecurrence MaxRecurrence { get; set; }

    }
}
