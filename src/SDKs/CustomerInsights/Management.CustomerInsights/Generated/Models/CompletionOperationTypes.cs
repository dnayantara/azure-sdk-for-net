// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CompletionOperationTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompletionOperationTypes
    {
        [EnumMember(Value = "DoNothing")]
        DoNothing,
        [EnumMember(Value = "DeleteFile")]
        DeleteFile,
        [EnumMember(Value = "MoveFile")]
        MoveFile
    }
}
