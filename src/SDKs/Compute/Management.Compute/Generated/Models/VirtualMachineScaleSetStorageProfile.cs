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
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    public partial class VirtualMachineScaleSetStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        public VirtualMachineScaleSetStorageProfile() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetStorageProfile class.
        /// </summary>
        /// <param name="imageReference">The image reference.</param>
        /// <param name="osDisk">The OS disk.</param>
        /// <param name="dataDisks">The data disks.</param>
        public VirtualMachineScaleSetStorageProfile(ImageReference imageReference = default(ImageReference), VirtualMachineScaleSetOSDisk osDisk = default(VirtualMachineScaleSetOSDisk), IList<VirtualMachineScaleSetDataDisk> dataDisks = default(IList<VirtualMachineScaleSetDataDisk>))
        {
            ImageReference = imageReference;
            OsDisk = osDisk;
            DataDisks = dataDisks;
        }

        /// <summary>
        /// Gets or sets the image reference.
        /// </summary>
        [JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the OS disk.
        /// </summary>
        [JsonProperty(PropertyName = "osDisk")]
        public VirtualMachineScaleSetOSDisk OsDisk { get; set; }

        /// <summary>
        /// Gets or sets the data disks.
        /// </summary>
        [JsonProperty(PropertyName = "dataDisks")]
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (OsDisk != null)
            {
                OsDisk.Validate();
            }
            if (DataDisks != null)
            {
                foreach (var element in DataDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}

