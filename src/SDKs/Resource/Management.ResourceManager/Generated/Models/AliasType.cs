// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The alias type.
    /// </summary>
    public partial class AliasType
    {
        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        public AliasType()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        /// <param name="name">The alias name.</param>
        /// <param name="paths">The paths for an alias.</param>
        public AliasType(string name = default(string), IList<AliasPathType> paths = default(IList<AliasPathType>))
        {
            Name = name;
            Paths = paths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alias name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the paths for an alias.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<AliasPathType> Paths { get; set; }

    }
}
