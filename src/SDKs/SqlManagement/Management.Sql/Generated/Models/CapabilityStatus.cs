// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CapabilityStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CapabilityStatus
    {
        [EnumMember(Value = "Visible")]
        Visible,
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
}
