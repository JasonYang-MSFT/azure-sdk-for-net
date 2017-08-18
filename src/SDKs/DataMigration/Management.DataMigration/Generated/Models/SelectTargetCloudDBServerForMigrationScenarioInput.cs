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
    /// Input for select target cloud db scenario
    /// </summary>
    public partial class SelectTargetCloudDBServerForMigrationScenarioInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SelectTargetCloudDBServerForMigrationScenarioInput class.
        /// </summary>
        public SelectTargetCloudDBServerForMigrationScenarioInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SelectTargetCloudDBServerForMigrationScenarioInput class.
        /// </summary>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        public SelectTargetCloudDBServerForMigrationScenarioInput(ConnectionInfo targetConnectionInfo)
        {
            TargetConnectionInfo = targetConnectionInfo;
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
        }
    }
}
