// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConditionOperator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionOperator
    {
        [EnumMember(Value = "GreaterThan")]
        GreaterThan,
        [EnumMember(Value = "GreaterThanOrEqual")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LessThan")]
        LessThan,
        [EnumMember(Value = "LessThanOrEqual")]
        LessThanOrEqual
    }
}
