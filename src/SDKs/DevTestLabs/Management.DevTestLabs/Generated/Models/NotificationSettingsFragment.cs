// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Notification settings for a schedule.
    /// </summary>
    public partial class NotificationSettingsFragment
    {
        /// <summary>
        /// Initializes a new instance of the NotificationSettingsFragment
        /// class.
        /// </summary>
        public NotificationSettingsFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotificationSettingsFragment
        /// class.
        /// </summary>
        /// <param name="status">If notifications are enabled for this schedule
        /// (i.e. Enabled, Disabled). Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="timeInMinutes">Time in minutes before event at which
        /// notification will be sent.</param>
        /// <param name="webhookUrl">The webhook URL to which the notification
        /// will be sent.</param>
        public NotificationSettingsFragment(string status = default(string), int? timeInMinutes = default(int?), string webhookUrl = default(string))
        {
            Status = status;
            TimeInMinutes = timeInMinutes;
            WebhookUrl = webhookUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if notifications are enabled for this schedule (i.e.
        /// Enabled, Disabled). Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets time in minutes before event at which notification
        /// will be sent.
        /// </summary>
        [JsonProperty(PropertyName = "timeInMinutes")]
        public int? TimeInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL to which the notification will be
        /// sent.
        /// </summary>
        [JsonProperty(PropertyName = "webhookUrl")]
        public string WebhookUrl { get; set; }

    }
}
