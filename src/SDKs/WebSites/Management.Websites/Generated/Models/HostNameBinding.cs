// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A hostname binding object.
    /// </summary>
    [JsonTransformation]
    public partial class HostNameBinding : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HostNameBinding class.
        /// </summary>
        public HostNameBinding() { }

        /// <summary>
        /// Initializes a new instance of the HostNameBinding class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="hostNameBindingName">Hostname.</param>
        /// <param name="siteName">App Service app name.</param>
        /// <param name="domainId">Fully qualified ARM domain resource
        /// URI.</param>
        /// <param name="azureResourceName">Azure resource name.</param>
        /// <param name="azureResourceType">Azure resource type. Possible
        /// values include: 'Website', 'TrafficManager'</param>
        /// <param name="customHostNameDnsRecordType">Custom DNS record type.
        /// Possible values include: 'CName', 'A'</param>
        /// <param name="hostNameType">Hostname type. Possible values include:
        /// 'Verified', 'Managed'</param>
        /// <param name="sslState">SSL type. Possible values include:
        /// 'Disabled', 'SniEnabled', 'IpBasedEnabled'</param>
        /// <param name="thumbprint">SSL certificate thumbprint</param>
        /// <param name="virtualIP">Virtual IP address assigned to the hostname
        /// if IP based SSL is enabled.</param>
        public HostNameBinding(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string hostNameBindingName = default(string), string siteName = default(string), string domainId = default(string), string azureResourceName = default(string), AzureResourceType? azureResourceType = default(AzureResourceType?), CustomHostNameDnsRecordType? customHostNameDnsRecordType = default(CustomHostNameDnsRecordType?), HostNameType? hostNameType = default(HostNameType?), SslState? sslState = default(SslState?), string thumbprint = default(string), string virtualIP = default(string))
            : base(location, id, name, kind, type, tags)
        {
            HostNameBindingName = hostNameBindingName;
            SiteName = siteName;
            DomainId = domainId;
            AzureResourceName = azureResourceName;
            AzureResourceType = azureResourceType;
            CustomHostNameDnsRecordType = customHostNameDnsRecordType;
            HostNameType = hostNameType;
            SslState = sslState;
            Thumbprint = thumbprint;
            VirtualIP = virtualIP;
        }

        /// <summary>
        /// Gets or sets hostname.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string HostNameBindingName { get; set; }

        /// <summary>
        /// Gets or sets app Service app name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM domain resource URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domainId")]
        public string DomainId { get; set; }

        /// <summary>
        /// Gets or sets azure resource name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureResourceName")]
        public string AzureResourceName { get; set; }

        /// <summary>
        /// Gets or sets azure resource type. Possible values include:
        /// 'Website', 'TrafficManager'
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureResourceType")]
        public AzureResourceType? AzureResourceType { get; set; }

        /// <summary>
        /// Gets or sets custom DNS record type. Possible values include:
        /// 'CName', 'A'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customHostNameDnsRecordType")]
        public CustomHostNameDnsRecordType? CustomHostNameDnsRecordType { get; set; }

        /// <summary>
        /// Gets or sets hostname type. Possible values include: 'Verified',
        /// 'Managed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostNameType")]
        public HostNameType? HostNameType { get; set; }

        /// <summary>
        /// Gets or sets SSL type. Possible values include: 'Disabled',
        /// 'SniEnabled', 'IpBasedEnabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslState")]
        public SslState? SslState { get; set; }

        /// <summary>
        /// Gets or sets SSL certificate thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets virtual IP address assigned to the hostname if IP
        /// based SSL is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

