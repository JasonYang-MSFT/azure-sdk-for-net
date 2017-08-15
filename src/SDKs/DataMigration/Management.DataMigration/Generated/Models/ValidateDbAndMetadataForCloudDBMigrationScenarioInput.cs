// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
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
    /// Input for validate db and metadata for cloud db scenario
    /// </summary>
    public partial class ValidateDbAndMetadataForCloudDBMigrationScenarioInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForCloudDBMigrationScenarioInput class.
        /// </summary>
        public ValidateDbAndMetadataForCloudDBMigrationScenarioInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForCloudDBMigrationScenarioInput class.
        /// </summary>
        /// <param name="targetConnectionInfo">Information for connecting to
        /// target</param>
        /// <param name="selectedDatabases">Databases to migrate</param>
        /// <param name="backupShareUserName">User name credential to connect
        /// to the backup share location</param>
        /// <param name="backupSharePassword">Password credential used to
        /// connect to the backup share location. It must be RSA encrypted by
        /// the public key of the VM, then base64 encoded. It must never be the
        /// plaintext! Cryptography class contains helper methods to perform
        /// the encryption.
        /// </param>
        public ValidateDbAndMetadataForCloudDBMigrationScenarioInput(ConnectionInfo targetConnectionInfo, IList<MigrationScenarioDatabaseInfo> selectedDatabases, string backupShareUserName, string backupSharePassword = default(string))
        {
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            BackupShareUserName = backupShareUserName;
            BackupSharePassword = backupSharePassword;
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
        /// Gets or sets user name credential to connect to the backup share
        /// location
        /// </summary>
        [JsonProperty(PropertyName = "backupShareUserName")]
        public string BackupShareUserName { get; set; }

        /// <summary>
        /// Gets or sets password credential used to connect to the backup
        /// share location. It must be RSA encrypted by the public key of the
        /// VM, then base64 encoded. It must never be the plaintext!
        /// Cryptography class contains helper methods to perform the
        /// encryption.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "backupSharePassword")]
        public string BackupSharePassword { get; set; }

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
            if (BackupShareUserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackupShareUserName");
            }
        }
    }
}
