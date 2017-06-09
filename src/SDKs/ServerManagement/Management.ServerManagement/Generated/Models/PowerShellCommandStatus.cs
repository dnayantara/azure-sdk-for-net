// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServerManagement;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result status from invoking a PowerShell command.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PowerShellCommandStatus : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandStatus class.
        /// </summary>
        public PowerShellCommandStatus()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandStatus class.
        /// </summary>
        /// <param name="id">Resource Manager Resource ID.</param>
        /// <param name="type">Resource Manager Resource Type.</param>
        /// <param name="name">Resource Manager Resource Name.</param>
        /// <param name="location">Resource Manager Resource Location.</param>
        /// <param name="tags">Resource Manager Resource Tags.</param>
        public PowerShellCommandStatus(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), IList<PowerShellCommandResult> results = default(IList<PowerShellCommandResult>), string pssession = default(string), string command = default(string), bool? completed = default(bool?))
            : base(id, type, name, location, tags, etag)
        {
            Results = results;
            Pssession = pssession;
            Command = command;
            Completed = completed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.results")]
        public IList<PowerShellCommandResult> Results { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.pssession")]
        public string Pssession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.command")]
        public string Command { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.completed")]
        public bool? Completed { get; set; }

    }
}
