// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of hybrid runbook worker group.
    /// </summary>
    public partial class HybridRunbookWorkerGroup
    {
        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorkerGroup class.
        /// </summary>
        public HybridRunbookWorkerGroup()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorkerGroup class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="name">Gets or sets the name of the group.</param>
        /// <param name="hybridRunbookWorkers">Gets or sets the list of hybrid
        /// runbook workers.</param>
        /// <param name="credential">Sets the credential of a worker
        /// group.</param>
        public HybridRunbookWorkerGroup(string id = default(string), string name = default(string), IList<HybridRunbookWorker> hybridRunbookWorkers = default(IList<HybridRunbookWorker>), RunAsCredentialAssociationProperty credential = default(RunAsCredentialAssociationProperty))
        {
            Id = id;
            Name = name;
            HybridRunbookWorkers = hybridRunbookWorkers;
            Credential = credential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of hybrid runbook workers.
        /// </summary>
        [JsonProperty(PropertyName = "hybridRunbookWorkers")]
        public IList<HybridRunbookWorker> HybridRunbookWorkers { get; set; }

        /// <summary>
        /// Gets or sets sets the credential of a worker group.
        /// </summary>
        [JsonProperty(PropertyName = "credential")]
        public RunAsCredentialAssociationProperty Credential { get; set; }

    }
}
