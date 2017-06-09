// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WorkerSizeOptions.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkerSizeOptions
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Small")]
        Small,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "Large")]
        Large
    }
}

