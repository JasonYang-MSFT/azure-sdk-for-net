// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataMigration;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Database level result for StartAzureSqlDbMigrationScenario
    /// </summary>
    public partial class StartAzureSqlDbMigrationScenarioDatabaseLevelResult : StartMigrationScenarioDatabaseLevelResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StartAzureSqlDbMigrationScenarioDatabaseLevelResult class.
        /// </summary>
        public StartAzureSqlDbMigrationScenarioDatabaseLevelResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StartAzureSqlDbMigrationScenarioDatabaseLevelResult class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="name">Name of the database</param>
        /// <param name="state">Current state of migration. Possible values
        /// include: 'None', 'InProgress', 'Failed', 'Warning', 'Completed',
        /// 'Skipped'</param>
        /// <param name="stage">Current stage of migration. Possible values
        /// include: 'None', 'Initialize', 'Backup', 'FileCopy', 'Restore',
        /// 'Completed'</param>
        /// <param name="startedOn">Migration start time</param>
        /// <param name="endedOn">Migration end time</param>
        /// <param name="message">Migration progress message</param>
        /// <param name="exceptionsAndWarnings">Migration exceptions and
        /// warnings</param>
        /// <param name="numberOfObjectsCompleted">Number of database
        /// artifacts/objects completed</param>
        /// <param name="numberOfObjects">Total number of database
        /// artifacts/objects</param>
        /// <param name="errorCount">Count of database/object errors</param>
        /// <param name="objectSummary">Source databases as a map from database
        /// name to database id</param>
        public StartAzureSqlDbMigrationScenarioDatabaseLevelResult(string id = default(string), string name = default(string), MigrationState? state = default(MigrationState?), DatabaseMigrationStage? stage = default(DatabaseMigrationStage?), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), string message = default(string), IList<ReportableException> exceptionsAndWarnings = default(IList<ReportableException>), int? numberOfObjectsCompleted = default(int?), int? numberOfObjects = default(int?), int? errorCount = default(int?), IDictionary<string, StartMigrationScenarioObjectSummaryResult> objectSummary = default(IDictionary<string, StartMigrationScenarioObjectSummaryResult>))
            : base(id, name, state, stage, startedOn, endedOn, message, exceptionsAndWarnings, numberOfObjectsCompleted, numberOfObjects, errorCount, objectSummary)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
