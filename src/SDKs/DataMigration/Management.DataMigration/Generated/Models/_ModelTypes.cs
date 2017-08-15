// --------------------------------------------------------------------------------------------------------------------
// <copyright file="_ModelTypes.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.Azure.DataMigrationService.Models
{
    // This is temporary workaround until we can fix the back-end to not rely on the $type property.
    // The problem is that scenario implementations try to deserialize inputs into interface types,
    // which does not work, unless you provide an explicit type reference in the JSON through $type property.
    // This is not correct, as clients don't know our internal types and should not be passing this.

    partial class ConnectionInfo
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Advisor.Common.Models.ConnectionInfo, Microsoft.SqlServer.Advisor.Common"; } }
    }

    partial class LoadMigrationProjectFileScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts.Migration.LoadMigrationProjectFileScenarioInput, Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts"; } }
    }

    partial class MigrationScenarioDatabaseInfo
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.MigrationScenarioDatabaseInfo, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class ScenarioDatabaseFileInfo
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.ScenarioDatabaseFileInfo, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class SelectMySqlSourceScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts.Migration.SelectMySqlSourceScenarioInput, Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts"; } }
    }

    partial class SelectOracleSourceScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts.Migration.SelectOracleSourceScenarioInput, Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts"; } }
    }

    partial class SelectSourceServerForMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.SelectSourceServerForMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class SelectTargetCloudDBServerForMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.SelectTargetCloudDBServerForMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class SelectTargetServerForMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.SelectTargetServerForMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class StartCloudDBMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.StartCloudDBMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class StartMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.StartMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class StartMySqlMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts.Migration.StartMySqlMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts"; } }
    }

    partial class StartOracleMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts.Migration.StartOracleMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Foreign.Scenarios.Contracts"; } }
    }

    partial class ValidateDbAndMetadataForCloudDBMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.ValidateDbAndMetadataForCloudDBMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class ValidateDbAndMetadataForMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.ValidateDbAndMetadataForMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class AzureSqlDbDatabaseInfo
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.AzureSqlDbDatabaseInfo, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }

    partial class StartAzureSqlDbMigrationScenarioInput
    {
        [JsonProperty("$type", Order = int.MinValue)]
        public string ContractType { get { return "Microsoft.SqlServer.Migration.Service.Scenarios.Contracts.Migration.StartAzureSqlDbMigrationScenarioInput, Microsoft.SqlServer.Migration.Service.Scenarios.Contracts"; } }
    }
}
