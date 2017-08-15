// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for Select Oracle Source Scenario
    /// </summary>
    public partial class SelectOracleSourceScenarioInput
    {
        /// <summary>
        /// Initializes a new instance of the SelectOracleSourceScenarioInput
        /// class.
        /// </summary>
        public SelectOracleSourceScenarioInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelectOracleSourceScenarioInput
        /// class.
        /// </summary>
        /// <param name="sourceConnectionInfo">Information for connecting to
        /// Oracle source</param>
        public SelectOracleSourceScenarioInput(OracleConnectionInfo sourceConnectionInfo)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information for connecting to Oracle source
        /// </summary>
        [JsonProperty(PropertyName = "sourceConnectionInfo")]
        public OracleConnectionInfo SourceConnectionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceConnectionInfo");
            }
        }
    }
}
