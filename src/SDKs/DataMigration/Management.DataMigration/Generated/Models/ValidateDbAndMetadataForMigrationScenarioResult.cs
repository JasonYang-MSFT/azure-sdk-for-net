// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
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
    /// Scenario result for ValidateDbAndMetadataForMigrationScenario
    /// </summary>
    public partial class ValidateDbAndMetadataForMigrationScenarioResult : MigrationScenarioResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForMigrationScenarioResult class.
        /// </summary>
        public ValidateDbAndMetadataForMigrationScenarioResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateDbAndMetadataForMigrationScenarioResult class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="name">Name of database</param>
        /// <param name="restoreDatabaseNameErrors">Errors associated with the
        /// RestoreDatabaseName</param>
        /// <param name="backupAndRestoreFolderErrors">Errors associated with
        /// the BackupAndRestoreFolder path</param>
        /// <param name="databaseFilesErrors">Errors associated with the
        /// database files</param>
        public ValidateDbAndMetadataForMigrationScenarioResult(string id = default(string), string name = default(string), IList<ReportableException> restoreDatabaseNameErrors = default(IList<ReportableException>), IList<ReportableException> backupAndRestoreFolderErrors = default(IList<ReportableException>), IDictionary<string, IList<ReportableException>> databaseFilesErrors = default(IDictionary<string, IList<ReportableException>>))
            : base(id)
        {
            Name = name;
            RestoreDatabaseNameErrors = restoreDatabaseNameErrors;
            BackupAndRestoreFolderErrors = backupAndRestoreFolderErrors;
            DatabaseFilesErrors = databaseFilesErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of database
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets errors associated with the RestoreDatabaseName
        /// </summary>
        [JsonProperty(PropertyName = "restoreDatabaseNameErrors")]
        public IList<ReportableException> RestoreDatabaseNameErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with the BackupAndRestoreFolder path
        /// </summary>
        [JsonProperty(PropertyName = "backupAndRestoreFolderErrors")]
        public IList<ReportableException> BackupAndRestoreFolderErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with the database files
        /// </summary>
        [JsonProperty(PropertyName = "databaseFilesErrors")]
        public IDictionary<string, IList<ReportableException>> DatabaseFilesErrors { get; private set; }

    }
}
