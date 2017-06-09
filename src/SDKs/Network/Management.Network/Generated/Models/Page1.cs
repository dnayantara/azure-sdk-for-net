// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a page in Azure responses.
    /// </summary>
    /// <typeparam name="T">Type of the page content items</typeparam>
    [JsonObject]
    public class Page1<T> : IPage<T>
    {
         /// <summary>
         /// Gets the link to the next page.
         /// </summary>
         [JsonProperty("")]
         public string NextPageLink { get; private set; }

         [JsonProperty("value")]
         private IList<T> Items{ get; set; }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         public IEnumerator<T> GetEnumerator()
         {
              return Items == null ? System.Linq.Enumerable.Empty<T>().GetEnumerator() : Items.GetEnumerator();
         }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         IEnumerator IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
    }
}
