// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow filter.
    /// </summary>
    public partial class WorkflowFilter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowFilter class.
        /// </summary>
        public WorkflowFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowFilter class.
        /// </summary>
        /// <param name="state">The state of workflows. Possible values
        /// include: 'NotSpecified', 'Completed', 'Enabled', 'Disabled',
        /// 'Deleted', 'Suspended'</param>
        public WorkflowFilter(WorkflowState? state = default(WorkflowState?))
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of workflows. Possible values include:
        /// 'NotSpecified', 'Completed', 'Enabled', 'Disabled', 'Deleted',
        /// 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public WorkflowState? State { get; set; }

    }
}
