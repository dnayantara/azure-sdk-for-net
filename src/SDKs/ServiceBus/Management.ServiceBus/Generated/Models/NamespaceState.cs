// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for NamespaceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NamespaceState
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Activating")]
        Activating,
        [EnumMember(Value = "Enabling")]
        Enabling,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Disabling")]
        Disabling,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "SoftDeleting")]
        SoftDeleting,
        [EnumMember(Value = "SoftDeleted")]
        SoftDeleted,
        [EnumMember(Value = "Removing")]
        Removing,
        [EnumMember(Value = "Removed")]
        Removed,
        [EnumMember(Value = "Failed")]
        Failed
    }
}
