// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schedules applicable to a virtual machine. The schedules may have been
    /// defined on a VM or on lab level.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicableScheduleFragment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicableScheduleFragment class.
        /// </summary>
        public ApplicableScheduleFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicableScheduleFragment class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="labVmsShutdown">The auto-shutdown schedule, if one has
        /// been set at the lab or lab resource level.</param>
        /// <param name="labVmsStartup">The auto-startup schedule, if one has
        /// been set at the lab or lab resource level.</param>
        public ApplicableScheduleFragment(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ScheduleFragment labVmsShutdown = default(ScheduleFragment), ScheduleFragment labVmsStartup = default(ScheduleFragment))
            : base(id, name, type, location, tags)
        {
            LabVmsShutdown = labVmsShutdown;
            LabVmsStartup = labVmsStartup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the auto-shutdown schedule, if one has been set at the
        /// lab or lab resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsShutdown")]
        public ScheduleFragment LabVmsShutdown { get; set; }

        /// <summary>
        /// Gets or sets the auto-startup schedule, if one has been set at the
        /// lab or lab resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsStartup")]
        public ScheduleFragment LabVmsStartup { get; set; }

    }
}
