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
    /// Migration scenario result base object
    /// </summary>
    public partial class MigrationScenarioResult
    {
        /// <summary>
        /// Initializes a new instance of the MigrationScenarioResult class.
        /// </summary>
        public MigrationScenarioResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationScenarioResult class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        public MigrationScenarioResult(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
