// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set extension profile.
    /// </summary>
    public partial class VirtualMachineScaleSetExtensionProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProfile class.
        /// </summary>
        public VirtualMachineScaleSetExtensionProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionProfile class.
        /// </summary>
        /// <param name="extensions">The virtual machine scale set child
        /// extension resources.</param>
        public VirtualMachineScaleSetExtensionProfile(IList<VirtualMachineScaleSetExtension> extensions = default(IList<VirtualMachineScaleSetExtension>))
        {
            Extensions = extensions;
        }

        /// <summary>
        /// Gets or sets the virtual machine scale set child extension
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineScaleSetExtension> Extensions { get; set; }

    }
}

