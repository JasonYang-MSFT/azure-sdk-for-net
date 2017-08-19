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
    /// Defines values for DataMigrationResultCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataMigrationResultCode
    {
        [EnumMember(Value = "Initial")]
        Initial,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "ObjectNotExistsInSource")]
        ObjectNotExistsInSource,
        [EnumMember(Value = "ObjectNotExistsInTarget")]
        ObjectNotExistsInTarget,
        [EnumMember(Value = "TargetObjectIsInaccessible")]
        TargetObjectIsInaccessible,
        [EnumMember(Value = "FatalError")]
        FatalError
    }
    internal static class DataMigrationResultCodeEnumExtension
    {
        internal static string ToSerializedValue(this DataMigrationResultCode? value)  =>
            value == null ? null : ((DataMigrationResultCode)value).ToSerializedValue();

        internal static string ToSerializedValue(this DataMigrationResultCode value)
        {
            switch( value )
            {
                case DataMigrationResultCode.Initial:
                    return "Initial";
                case DataMigrationResultCode.Completed:
                    return "Completed";
                case DataMigrationResultCode.ObjectNotExistsInSource:
                    return "ObjectNotExistsInSource";
                case DataMigrationResultCode.ObjectNotExistsInTarget:
                    return "ObjectNotExistsInTarget";
                case DataMigrationResultCode.TargetObjectIsInaccessible:
                    return "TargetObjectIsInaccessible";
                case DataMigrationResultCode.FatalError:
                    return "FatalError";
            }
            return null;
        }

        internal static DataMigrationResultCode? ParseDataMigrationResultCode(this string value)
        {
            switch( value )
            {
                case "Initial":
                    return DataMigrationResultCode.Initial;
                case "Completed":
                    return DataMigrationResultCode.Completed;
                case "ObjectNotExistsInSource":
                    return DataMigrationResultCode.ObjectNotExistsInSource;
                case "ObjectNotExistsInTarget":
                    return DataMigrationResultCode.ObjectNotExistsInTarget;
                case "TargetObjectIsInaccessible":
                    return DataMigrationResultCode.TargetObjectIsInaccessible;
                case "FatalError":
                    return DataMigrationResultCode.FatalError;
            }
            return null;
        }
    }
}
