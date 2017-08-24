// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataMigration;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of an action supported by the Data Migration Service
    /// </summary>
    public partial class ServiceOperation
    {
        /// <summary>
        /// Initializes a new instance of the ServiceOperation class.
        /// </summary>
        public ServiceOperation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceOperation class.
        /// </summary>
        /// <param name="name">The fully qualified action name, e.g.
        /// Microsoft.DataMigration/services/read</param>
        /// <param name="display">Localized display text</param>
        public ServiceOperation(string name = default(string), ServiceOperationDisplay display = default(ServiceOperationDisplay))
        {
            Name = name;
            Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified action name, e.g.
        /// Microsoft.DataMigration/services/read
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets localized display text
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ServiceOperationDisplay Display { get; set; }

    }
}
