// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The connector mapping properties.
    /// </summary>
    public partial class ConnectorMappingProperties
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMappingProperties class.
        /// </summary>
        public ConnectorMappingProperties()
        {
            Format = new ConnectorMappingFormat();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMappingProperties class.
        /// </summary>
        /// <param name="errorManagement">The error management setting for the
        /// mapping.</param>
        /// <param name="format">The format of mapping property.</param>
        /// <param name="availability">The availability of mapping
        /// property.</param>
        /// <param name="structure">Ingestion mapping information at property
        /// level.</param>
        /// <param name="completeOperation">The operation after import is
        /// done.</param>
        /// <param name="folderPath">The folder path for the mapping.</param>
        /// <param name="fileFilter">The file filter for the mapping.</param>
        /// <param name="hasHeader">If the file contains a header or
        /// not.</param>
        public ConnectorMappingProperties(ConnectorMappingErrorManagement errorManagement, ConnectorMappingFormat format, ConnectorMappingAvailability availability, IList<ConnectorMappingStructure> structure, ConnectorMappingCompleteOperation completeOperation, string folderPath = default(string), string fileFilter = default(string), bool? hasHeader = default(bool?))
        {
            Format = new ConnectorMappingFormat();
            FolderPath = folderPath;
            FileFilter = fileFilter;
            HasHeader = hasHeader;
            ErrorManagement = errorManagement;
            Format = format;
            Availability = availability;
            Structure = structure;
            CompleteOperation = completeOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the folder path for the mapping.
        /// </summary>
        [JsonProperty(PropertyName = "folderPath")]
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets or sets the file filter for the mapping.
        /// </summary>
        [JsonProperty(PropertyName = "fileFilter")]
        public string FileFilter { get; set; }

        /// <summary>
        /// Gets or sets if the file contains a header or not.
        /// </summary>
        [JsonProperty(PropertyName = "hasHeader")]
        public bool? HasHeader { get; set; }

        /// <summary>
        /// Gets or sets the error management setting for the mapping.
        /// </summary>
        [JsonProperty(PropertyName = "errorManagement")]
        public ConnectorMappingErrorManagement ErrorManagement { get; set; }

        /// <summary>
        /// Gets or sets the format of mapping property.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public ConnectorMappingFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the availability of mapping property.
        /// </summary>
        [JsonProperty(PropertyName = "availability")]
        public ConnectorMappingAvailability Availability { get; set; }

        /// <summary>
        /// Gets or sets ingestion mapping information at property level.
        /// </summary>
        [JsonProperty(PropertyName = "structure")]
        public IList<ConnectorMappingStructure> Structure { get; set; }

        /// <summary>
        /// Gets or sets the operation after import is done.
        /// </summary>
        [JsonProperty(PropertyName = "completeOperation")]
        public ConnectorMappingCompleteOperation CompleteOperation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ErrorManagement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ErrorManagement");
            }
            if (Format == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Format");
            }
            if (Availability == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Availability");
            }
            if (Structure == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Structure");
            }
            if (CompleteOperation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CompleteOperation");
            }
            if (ErrorManagement != null)
            {
                ErrorManagement.Validate();
            }
            if (Availability != null)
            {
                Availability.Validate();
            }
            if (Structure != null)
            {
                foreach (var element in Structure)
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
