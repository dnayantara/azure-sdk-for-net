// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Insights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rule condition based on a certain number of locations failing.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.LocationThresholdRuleCondition")]
    public partial class LocationThresholdRuleCondition : RuleCondition
    {
        /// <summary>
        /// Initializes a new instance of the LocationThresholdRuleCondition
        /// class.
        /// </summary>
        public LocationThresholdRuleCondition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationThresholdRuleCondition
        /// class.
        /// </summary>
        /// <param name="failedLocationCount">the number of locations that must
        /// fail to activate the alert.</param>
        /// <param name="dataSource">the resource from which the rule collects
        /// its data. For this type dataSource will always be of type
        /// RuleMetricDataSource.</param>
        /// <param name="windowSize">the period of time (in ISO 8601 duration
        /// format) that is used to monitor alert activity based on the
        /// threshold. If specified then it must be between 5 minutes and 1
        /// day.</param>
        public LocationThresholdRuleCondition(int failedLocationCount, RuleDataSource dataSource = default(RuleDataSource), System.TimeSpan? windowSize = default(System.TimeSpan?))
        {
            DataSource = dataSource;
            WindowSize = windowSize;
            FailedLocationCount = failedLocationCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource from which the rule collects its data.
        /// For this type dataSource will always be of type
        /// RuleMetricDataSource.
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public RuleDataSource DataSource { get; set; }

        /// <summary>
        /// Gets or sets the period of time (in ISO 8601 duration format) that
        /// is used to monitor alert activity based on the threshold. If
        /// specified then it must be between 5 minutes and 1 day.
        /// </summary>
        [JsonProperty(PropertyName = "windowSize")]
        public System.TimeSpan? WindowSize { get; set; }

        /// <summary>
        /// Gets or sets the number of locations that must fail to activate the
        /// alert.
        /// </summary>
        [JsonProperty(PropertyName = "failedLocationCount")]
        public int FailedLocationCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
