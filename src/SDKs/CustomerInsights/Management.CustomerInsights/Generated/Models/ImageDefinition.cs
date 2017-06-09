// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The image definition.
    /// </summary>
    public partial class ImageDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ImageDefinition class.
        /// </summary>
        public ImageDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDefinition class.
        /// </summary>
        /// <param name="imageExists">Whether image exists already.</param>
        /// <param name="contentUrl">Content URL for the image blob.</param>
        /// <param name="relativePath">Relative path of the image.</param>
        public ImageDefinition(bool? imageExists = default(bool?), string contentUrl = default(string), string relativePath = default(string))
        {
            ImageExists = imageExists;
            ContentUrl = contentUrl;
            RelativePath = relativePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether image exists already.
        /// </summary>
        [JsonProperty(PropertyName = "imageExists")]
        public bool? ImageExists { get; set; }

        /// <summary>
        /// Gets or sets content URL for the image blob.
        /// </summary>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// Gets or sets relative path of the image.
        /// </summary>
        [JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

    }
}
