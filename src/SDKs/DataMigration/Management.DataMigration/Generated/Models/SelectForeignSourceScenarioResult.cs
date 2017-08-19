// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Scenario result for ValidateDbAndMetadataForCloudDBMigrationScenario
    /// </summary>
    public partial class SelectForeignSourceScenarioResult : MigrationScenarioResult
    {
        /// <summary>
        /// Initializes a new instance of the SelectForeignSourceScenarioResult
        /// class.
        /// </summary>
        public SelectForeignSourceScenarioResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelectForeignSourceScenarioResult
        /// class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="serverProperties">Server properties</param>
        /// <param name="validationErrors">Validation errors associated with
        /// the scenario</param>
        public SelectForeignSourceScenarioResult(string id = default(string), ForeignServerProperties serverProperties = default(ForeignServerProperties), IList<ReportableException> validationErrors = default(IList<ReportableException>))
            : base(id)
        {
            ServerProperties = serverProperties;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets server properties
        /// </summary>
        [JsonProperty(PropertyName = "serverProperties")]
        public ForeignServerProperties ServerProperties { get; private set; }

        /// <summary>
        /// Gets validation errors associated with the scenario
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<ReportableException> ValidationErrors { get; private set; }

    }
}
