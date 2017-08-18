// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
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
    /// Input for Select MySQL Source Scenario
    /// </summary>
    public partial class SelectMySqlSourceScenarioInput
    {
        /// <summary>
        /// Initializes a new instance of the SelectMySqlSourceScenarioInput
        /// class.
        /// </summary>
        public SelectMySqlSourceScenarioInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelectMySqlSourceScenarioInput
        /// class.
        /// </summary>
        /// <param name="sourceConnectionInfo">Information for connecting to
        /// MySQL source</param>
        public SelectMySqlSourceScenarioInput(MySqlConnectionInfo sourceConnectionInfo)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information for connecting to MySQL source
        /// </summary>
        [JsonProperty(PropertyName = "sourceConnectionInfo")]
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }

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
