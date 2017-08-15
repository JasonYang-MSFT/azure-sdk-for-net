// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A task resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NewServiceTask
    {
        /// <summary>
        /// Initializes a new instance of the NewServiceTask class.
        /// </summary>
        public NewServiceTask()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewServiceTask class.
        /// </summary>
        /// <param name="input">Arbitrary input to the worker</param>
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
        public NewServiceTask(string input = default(string), string scenarioId = default(string))
        {
            Input = input;
            ScenarioId = scenarioId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets arbitrary input to the worker
        /// </summary>
        [JsonProperty(PropertyName = "properties.input")]
        public string Input { get; set; }

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
        [JsonProperty(PropertyName = "properties.scenarioId")]
        public string ScenarioId { get; set; }

    }
}
