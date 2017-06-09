// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    public partial class AutoHealActions
    {
        /// <summary>
        /// Initializes a new instance of the AutoHealActions class.
        /// </summary>
        public AutoHealActions() { }

        /// <summary>
        /// Initializes a new instance of the AutoHealActions class.
        /// </summary>
        /// <param name="actionType">Predefined action to be taken. Possible
        /// values include: 'Recycle', 'LogEvent', 'CustomAction'</param>
        /// <param name="customAction">Custom action to be taken.</param>
        /// <param name="minProcessExecutionTime">Minimum time the process must
        /// execute
        /// before taking the action</param>
        public AutoHealActions(AutoHealActionType? actionType = default(AutoHealActionType?), AutoHealCustomAction customAction = default(AutoHealCustomAction), string minProcessExecutionTime = default(string))
        {
            ActionType = actionType;
            CustomAction = customAction;
            MinProcessExecutionTime = minProcessExecutionTime;
        }

        /// <summary>
        /// Gets or sets predefined action to be taken. Possible values
        /// include: 'Recycle', 'LogEvent', 'CustomAction'
        /// </summary>
        [JsonProperty(PropertyName = "actionType")]
        public AutoHealActionType? ActionType { get; set; }

        /// <summary>
        /// Gets or sets custom action to be taken.
        /// </summary>
        [JsonProperty(PropertyName = "customAction")]
        public AutoHealCustomAction CustomAction { get; set; }

        /// <summary>
        /// Gets or sets minimum time the process must execute
        /// before taking the action
        /// </summary>
        [JsonProperty(PropertyName = "minProcessExecutionTime")]
        public string MinProcessExecutionTime { get; set; }

    }
}

