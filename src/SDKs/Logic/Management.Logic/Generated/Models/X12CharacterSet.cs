// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for X12CharacterSet.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum X12CharacterSet
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Basic")]
        Basic,
        [EnumMember(Value = "Extended")]
        Extended,
        [EnumMember(Value = "UTF8")]
        UTF8
    }
}
