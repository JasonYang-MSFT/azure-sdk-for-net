// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
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
    /// Defines values for ProjectTargetPlatform.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProjectTargetPlatform
    {
        [EnumMember(Value = "SQL10")]
        SQL10,
        [EnumMember(Value = "SQL11")]
        SQL11,
        [EnumMember(Value = "SQL12")]
        SQL12,
        [EnumMember(Value = "SQL13")]
        SQL13,
        [EnumMember(Value = "SQL14")]
        SQL14,
        [EnumMember(Value = "SQLDB")]
        SQLDB,
        [EnumMember(Value = "SQLDW")]
        SQLDW
    }
}
