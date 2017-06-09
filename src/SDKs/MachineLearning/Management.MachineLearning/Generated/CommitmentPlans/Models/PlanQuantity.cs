// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.CommitmentPlans;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the quantity a commitment plan provides of a metered
    /// resource.
    /// </summary>
    public partial class PlanQuantity
    {
        /// <summary>
        /// Initializes a new instance of the PlanQuantity class.
        /// </summary>
        public PlanQuantity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlanQuantity class.
        /// </summary>
        /// <param name="allowance">The quantity added to the commitment plan
        /// at an interval specified by its allowance frequency.</param>
        /// <param name="amount">The quantity available to the plan the last
        /// time usage was calculated.</param>
        /// <param name="includedQuantityMeter">The Azure meter for usage
        /// against included quantities.</param>
        /// <param name="overageMeter">The Azure meter for usage which exceeds
        /// included quantities.</param>
        public PlanQuantity(double? allowance = default(double?), double? amount = default(double?), string includedQuantityMeter = default(string), string overageMeter = default(string))
        {
            Allowance = allowance;
            Amount = amount;
            IncludedQuantityMeter = includedQuantityMeter;
            OverageMeter = overageMeter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the quantity added to the commitment plan at an interval
        /// specified by its allowance frequency.
        /// </summary>
        [JsonProperty(PropertyName = "allowance")]
        public double? Allowance { get; private set; }

        /// <summary>
        /// Gets the quantity available to the plan the last time usage was
        /// calculated.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public double? Amount { get; private set; }

        /// <summary>
        /// Gets the Azure meter for usage against included quantities.
        /// </summary>
        [JsonProperty(PropertyName = "includedQuantityMeter")]
        public string IncludedQuantityMeter { get; private set; }

        /// <summary>
        /// Gets the Azure meter for usage which exceeds included quantities.
        /// </summary>
        [JsonProperty(PropertyName = "overageMeter")]
        public string OverageMeter { get; private set; }

    }
}
