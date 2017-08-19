// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataMigrationService.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.DataMigrationService;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DatabaseMigrationStage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatabaseMigrationStage
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Initialize")]
        Initialize,
        [EnumMember(Value = "Backup")]
        Backup,
        [EnumMember(Value = "FileCopy")]
        FileCopy,
        [EnumMember(Value = "Restore")]
        Restore,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class DatabaseMigrationStageEnumExtension
    {
        internal static string ToSerializedValue(this DatabaseMigrationStage? value)  =>
            value == null ? null : ((DatabaseMigrationStage)value).ToSerializedValue();

        internal static string ToSerializedValue(this DatabaseMigrationStage value)
        {
            switch( value )
            {
                case DatabaseMigrationStage.None:
                    return "None";
                case DatabaseMigrationStage.Initialize:
                    return "Initialize";
                case DatabaseMigrationStage.Backup:
                    return "Backup";
                case DatabaseMigrationStage.FileCopy:
                    return "FileCopy";
                case DatabaseMigrationStage.Restore:
                    return "Restore";
                case DatabaseMigrationStage.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static DatabaseMigrationStage? ParseDatabaseMigrationStage(this string value)
        {
            switch( value )
            {
                case "None":
                    return DatabaseMigrationStage.None;
                case "Initialize":
                    return DatabaseMigrationStage.Initialize;
                case "Backup":
                    return DatabaseMigrationStage.Backup;
                case "FileCopy":
                    return DatabaseMigrationStage.FileCopy;
                case "Restore":
                    return DatabaseMigrationStage.Restore;
                case "Completed":
                    return DatabaseMigrationStage.Completed;
            }
            return null;
        }
    }
}
