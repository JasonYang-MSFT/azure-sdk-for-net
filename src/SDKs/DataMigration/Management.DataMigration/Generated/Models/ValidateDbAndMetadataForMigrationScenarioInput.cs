// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Input for validate db and metadata scenario
    /// </summary>
    public partial class ValidateDbAndMetadataForMigrationScenarioInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForMigrationScenarioInput class.
        /// </summary>
        public ValidateDbAndMetadataForMigrationScenarioInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForMigrationScenarioInput class.
        /// </summary>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        /// <param name="selectedDatabases">Databases to migrate</param>
        public ValidateDbAndMetadataForMigrationScenarioInput(ConnectionInfo targetConnectionInfo, IList<MigrationScenarioDatabaseInfo> selectedDatabases)
        {
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information for connecting to target
        /// </summary>
        [JsonProperty(PropertyName = "targetConnectionInfo")]
        public ConnectionInfo TargetConnectionInfo { get; set; }

        /// <summary>
        /// Gets or sets databases to migrate
        /// </summary>
        [JsonProperty(PropertyName = "selectedDatabases")]
        public IList<MigrationScenarioDatabaseInfo> SelectedDatabases { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetConnectionInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (SelectedDatabases == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SelectedDatabases");
            }
        }
    }
}
