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
    /// Task-specific properties
    /// </summary>
    public partial class ServiceTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTaskProperties class.
        /// </summary>
        public ServiceTaskProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTaskProperties class.
        /// </summary>
        /// <param name="errors">An array of errors</param>
        /// <param name="input">Arbitrary input to the worker</param>
        /// <param name="output">Output from the worker. Only generated by GET
        /// requests with the $expand parameter</param>
        /// <param name="scenarioId">The identifier of the scenario. Possible
        /// values include: 'DataMigration.GetUserTables',
        /// 'DataMigration.LoadMySqlMigrationProjectFile',
        /// 'DataMigration.LoadOracleMigrationProjectFile',
        /// 'DataMigration.RunAzureSQLDBMigration',
        /// 'DataMigration.RunCloudDBMigration', 'DataMigration.RunMigration',
        /// 'DataMigration.RunMySqlMigration',
        /// 'DataMigration.RunOracleMigration',
        /// 'DataMigration.SelectAnySqlMigrationTarget',
        /// 'DataMigration.SelectAzureSqlDbMigrationTarget',
        /// 'DataMigration.SelectCloudDBMigrationTarget',
        /// 'DataMigration.SelectMigrationSource',
        /// 'DataMigration.SelectMigrationTarget',
        /// 'DataMigration.ValidateCloudDBMigrationInput',
        /// 'DataMigration.ValidateMigrationInput',
        /// 'DataMigration.SelectOracleSourceScenarioId',
        /// 'DataMigration.SelectMySqlSourceScenarioId'</param>
        /// <param name="state">The state of the task. Possible values include:
        /// 'Canceled', 'Failed', 'FailedValidation', 'Faulted', 'Queued',
        /// 'Running', 'Succeeded', 'Unknown'</param>
        public ServiceTaskProperties(IList<ODataError> errors = default(IList<ODataError>), string input = default(string), IList<string> output = default(IList<string>), string scenarioId = default(string), ServiceTaskState? state = default(ServiceTaskState?))
        {
            Errors = errors;
            Input = input;
            Output = output;
            ScenarioId = scenarioId;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of errors
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ODataError> Errors { get; set; }

        /// <summary>
        /// Gets or sets arbitrary input to the worker
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public string Input { get; set; }

        /// <summary>
        /// Gets or sets output from the worker. Only generated by GET requests
        /// with the $expand parameter
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public IList<string> Output { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the scenario. Possible values
        /// include: 'DataMigration.GetUserTables',
        /// 'DataMigration.LoadMySqlMigrationProjectFile',
        /// 'DataMigration.LoadOracleMigrationProjectFile',
        /// 'DataMigration.RunAzureSQLDBMigration',
        /// 'DataMigration.RunCloudDBMigration', 'DataMigration.RunMigration',
        /// 'DataMigration.RunMySqlMigration',
        /// 'DataMigration.RunOracleMigration',
        /// 'DataMigration.SelectAnySqlMigrationTarget',
        /// 'DataMigration.SelectAzureSqlDbMigrationTarget',
        /// 'DataMigration.SelectCloudDBMigrationTarget',
        /// 'DataMigration.SelectMigrationSource',
        /// 'DataMigration.SelectMigrationTarget',
        /// 'DataMigration.ValidateCloudDBMigrationInput',
        /// 'DataMigration.ValidateMigrationInput',
        /// 'DataMigration.SelectOracleSourceScenarioId',
        /// 'DataMigration.SelectMySqlSourceScenarioId'
        /// </summary>
        [JsonProperty(PropertyName = "scenarioId")]
        public string ScenarioId { get; set; }

        /// <summary>
        /// Gets or sets the state of the task. Possible values include:
        /// 'Canceled', 'Failed', 'FailedValidation', 'Faulted', 'Queued',
        /// 'Running', 'Succeeded', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public ServiceTaskState? State { get; set; }

    }
}
