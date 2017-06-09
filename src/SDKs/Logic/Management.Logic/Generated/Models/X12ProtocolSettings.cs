// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The X12 agreement protocol settings.
    /// </summary>
    public partial class X12ProtocolSettings
    {
        /// <summary>
        /// Initializes a new instance of the X12ProtocolSettings class.
        /// </summary>
        public X12ProtocolSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12ProtocolSettings class.
        /// </summary>
        /// <param name="validationSettings">The X12 validation
        /// settings.</param>
        /// <param name="framingSettings">The X12 framing settings.</param>
        /// <param name="envelopeSettings">The X12 envelope settings.</param>
        /// <param name="acknowledgementSettings">The X12 acknowledgment
        /// settings.</param>
        /// <param name="messageFilter">The X12 message filter.</param>
        /// <param name="securitySettings">The X12 security settings.</param>
        /// <param name="processingSettings">The X12 processing
        /// settings.</param>
        /// <param name="schemaReferences">The X12 schema references.</param>
        /// <param name="envelopeOverrides">The X12 envelope override
        /// settings.</param>
        /// <param name="validationOverrides">The X12 validation override
        /// settings.</param>
        /// <param name="messageFilterList">The X12 message filter
        /// list.</param>
        /// <param name="x12DelimiterOverrides">The X12 delimiter override
        /// settings.</param>
        public X12ProtocolSettings(X12ValidationSettings validationSettings, X12FramingSettings framingSettings, X12EnvelopeSettings envelopeSettings, X12AcknowledgementSettings acknowledgementSettings, X12MessageFilter messageFilter, X12SecuritySettings securitySettings, X12ProcessingSettings processingSettings, IList<X12SchemaReference> schemaReferences, IList<X12EnvelopeOverride> envelopeOverrides = default(IList<X12EnvelopeOverride>), IList<X12ValidationOverride> validationOverrides = default(IList<X12ValidationOverride>), IList<X12MessageIdentifier> messageFilterList = default(IList<X12MessageIdentifier>), IList<X12DelimiterOverrides> x12DelimiterOverrides = default(IList<X12DelimiterOverrides>))
        {
            ValidationSettings = validationSettings;
            FramingSettings = framingSettings;
            EnvelopeSettings = envelopeSettings;
            AcknowledgementSettings = acknowledgementSettings;
            MessageFilter = messageFilter;
            SecuritySettings = securitySettings;
            ProcessingSettings = processingSettings;
            EnvelopeOverrides = envelopeOverrides;
            ValidationOverrides = validationOverrides;
            MessageFilterList = messageFilterList;
            SchemaReferences = schemaReferences;
            X12DelimiterOverrides = x12DelimiterOverrides;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the X12 validation settings.
        /// </summary>
        [JsonProperty(PropertyName = "validationSettings")]
        public X12ValidationSettings ValidationSettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 framing settings.
        /// </summary>
        [JsonProperty(PropertyName = "framingSettings")]
        public X12FramingSettings FramingSettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 envelope settings.
        /// </summary>
        [JsonProperty(PropertyName = "envelopeSettings")]
        public X12EnvelopeSettings EnvelopeSettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 acknowledgment settings.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementSettings")]
        public X12AcknowledgementSettings AcknowledgementSettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 message filter.
        /// </summary>
        [JsonProperty(PropertyName = "messageFilter")]
        public X12MessageFilter MessageFilter { get; set; }

        /// <summary>
        /// Gets or sets the X12 security settings.
        /// </summary>
        [JsonProperty(PropertyName = "securitySettings")]
        public X12SecuritySettings SecuritySettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 processing settings.
        /// </summary>
        [JsonProperty(PropertyName = "processingSettings")]
        public X12ProcessingSettings ProcessingSettings { get; set; }

        /// <summary>
        /// Gets or sets the X12 envelope override settings.
        /// </summary>
        [JsonProperty(PropertyName = "envelopeOverrides")]
        public IList<X12EnvelopeOverride> EnvelopeOverrides { get; set; }

        /// <summary>
        /// Gets or sets the X12 validation override settings.
        /// </summary>
        [JsonProperty(PropertyName = "validationOverrides")]
        public IList<X12ValidationOverride> ValidationOverrides { get; set; }

        /// <summary>
        /// Gets or sets the X12 message filter list.
        /// </summary>
        [JsonProperty(PropertyName = "messageFilterList")]
        public IList<X12MessageIdentifier> MessageFilterList { get; set; }

        /// <summary>
        /// Gets or sets the X12 schema references.
        /// </summary>
        [JsonProperty(PropertyName = "schemaReferences")]
        public IList<X12SchemaReference> SchemaReferences { get; set; }

        /// <summary>
        /// Gets or sets the X12 delimiter override settings.
        /// </summary>
        [JsonProperty(PropertyName = "x12DelimiterOverrides")]
        public IList<X12DelimiterOverrides> X12DelimiterOverrides { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ValidationSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ValidationSettings");
            }
            if (FramingSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FramingSettings");
            }
            if (EnvelopeSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EnvelopeSettings");
            }
            if (AcknowledgementSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AcknowledgementSettings");
            }
            if (MessageFilter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageFilter");
            }
            if (SecuritySettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecuritySettings");
            }
            if (ProcessingSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProcessingSettings");
            }
            if (SchemaReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaReferences");
            }
            if (ValidationSettings != null)
            {
                ValidationSettings.Validate();
            }
            if (FramingSettings != null)
            {
                FramingSettings.Validate();
            }
            if (EnvelopeSettings != null)
            {
                EnvelopeSettings.Validate();
            }
            if (AcknowledgementSettings != null)
            {
                AcknowledgementSettings.Validate();
            }
            if (MessageFilter != null)
            {
                MessageFilter.Validate();
            }
            if (SecuritySettings != null)
            {
                SecuritySettings.Validate();
            }
            if (ProcessingSettings != null)
            {
                ProcessingSettings.Validate();
            }
            if (EnvelopeOverrides != null)
            {
                foreach (var element in EnvelopeOverrides)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ValidationOverrides != null)
            {
                foreach (var element1 in ValidationOverrides)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (MessageFilterList != null)
            {
                foreach (var element2 in MessageFilterList)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (SchemaReferences != null)
            {
                foreach (var element3 in SchemaReferences)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (X12DelimiterOverrides != null)
            {
                foreach (var element4 in X12DelimiterOverrides)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
        }
    }
}
