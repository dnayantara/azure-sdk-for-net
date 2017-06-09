// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Extension Image.
    /// </summary>
    [JsonTransformation]
    public partial class VirtualMachineExtensionImage : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtensionImage
        /// class.
        /// </summary>
        public VirtualMachineExtensionImage() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineExtensionImage
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="operatingSystem">The operating system this extension
        /// supports.</param>
        /// <param name="computeRole">The type of role (IaaS or PaaS) this
        /// extension supports.</param>
        /// <param name="handlerSchema">The schema defined by publisher, where
        /// extension consumers should provide settings in a matching
        /// schema.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="vmScaleSetEnabled">Whether the extension can be used
        /// on xRP VMScaleSets. By default existing extensions are usable on
        /// scalesets, but there might be cases where a publisher wants to
        /// explicitly indicate the extension is only enabled for CRP VMs but
        /// not VMSS.</param>
        /// <param name="supportsMultipleExtensions">Whether the handler can
        /// support multiple extensions.</param>
        public VirtualMachineExtensionImage(string location, string operatingSystem, string computeRole, string handlerSchema, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? vmScaleSetEnabled = default(bool?), bool? supportsMultipleExtensions = default(bool?))
            : base(location, id, name, type, tags)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
        }

        /// <summary>
        /// Gets or sets the operating system this extension supports.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operatingSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets the type of role (IaaS or PaaS) this extension
        /// supports.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeRole")]
        public string ComputeRole { get; set; }

        /// <summary>
        /// Gets or sets the schema defined by publisher, where extension
        /// consumers should provide settings in a matching schema.
        /// </summary>
        [JsonProperty(PropertyName = "properties.handlerSchema")]
        public string HandlerSchema { get; set; }

        /// <summary>
        /// Gets or sets whether the extension can be used on xRP VMScaleSets.
        /// By default existing extensions are usable on scalesets, but there
        /// might be cases where a publisher wants to explicitly indicate the
        /// extension is only enabled for CRP VMs but not VMSS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmScaleSetEnabled")]
        public bool? VmScaleSetEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether the handler can support multiple extensions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsMultipleExtensions")]
        public bool? SupportsMultipleExtensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OperatingSystem == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatingSystem");
            }
            if (ComputeRole == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ComputeRole");
            }
            if (HandlerSchema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HandlerSchema");
            }
        }
    }
}

