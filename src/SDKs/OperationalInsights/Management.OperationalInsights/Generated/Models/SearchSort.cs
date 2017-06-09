// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Azure;
    using Management;
    using OperationalInsights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The sort parameters for search.
    /// </summary>
    public partial class SearchSort
    {
        /// <summary>
        /// Initializes a new instance of the SearchSort class.
        /// </summary>
        public SearchSort() { }

        /// <summary>
        /// Initializes a new instance of the SearchSort class.
        /// </summary>
        /// <param name="name">The name of the field the search query is sorted
        /// on.</param>
        /// <param name="order">The sort order of the search. Possible values
        /// include: 'asc', 'desc'</param>
        public SearchSort(string name = default(string), string order = default(string))
        {
            Name = name;
            Order = order;
        }

        /// <summary>
        /// Gets or sets the name of the field the search query is sorted on.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sort order of the search. Possible values include:
        /// 'asc', 'desc'
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public string Order { get; set; }

    }
}

