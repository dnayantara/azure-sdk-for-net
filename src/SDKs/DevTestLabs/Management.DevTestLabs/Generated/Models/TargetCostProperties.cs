// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a cost target.
    /// </summary>
    public partial class TargetCostProperties
    {
        /// <summary>
        /// Initializes a new instance of the TargetCostProperties class.
        /// </summary>
        public TargetCostProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetCostProperties class.
        /// </summary>
        /// <param name="status">Target cost status. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="target">Lab target cost</param>
        /// <param name="costThresholds">Cost thresholds.</param>
        /// <param name="cycleStartDateTime">Reporting cycle start
        /// date.</param>
        /// <param name="cycleEndDateTime">Reporting cycle end date.</param>
        /// <param name="cycleType">Reporting cycle type. Possible values
        /// include: 'CalendarMonth', 'Custom'</param>
        public TargetCostProperties(string status = default(string), int? target = default(int?), IList<CostThresholdProperties> costThresholds = default(IList<CostThresholdProperties>), System.DateTime? cycleStartDateTime = default(System.DateTime?), System.DateTime? cycleEndDateTime = default(System.DateTime?), string cycleType = default(string))
        {
            Status = status;
            Target = target;
            CostThresholds = costThresholds;
            CycleStartDateTime = cycleStartDateTime;
            CycleEndDateTime = cycleEndDateTime;
            CycleType = cycleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target cost status. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets lab target cost
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public int? Target { get; set; }

        /// <summary>
        /// Gets or sets cost thresholds.
        /// </summary>
        [JsonProperty(PropertyName = "costThresholds")]
        public IList<CostThresholdProperties> CostThresholds { get; set; }

        /// <summary>
        /// Gets or sets reporting cycle start date.
        /// </summary>
        [JsonProperty(PropertyName = "cycleStartDateTime")]
        public System.DateTime? CycleStartDateTime { get; set; }

        /// <summary>
        /// Gets or sets reporting cycle end date.
        /// </summary>
        [JsonProperty(PropertyName = "cycleEndDateTime")]
        public System.DateTime? CycleEndDateTime { get; set; }

        /// <summary>
        /// Gets or sets reporting cycle type. Possible values include:
        /// 'CalendarMonth', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "cycleType")]
        public string CycleType { get; set; }

    }
}
