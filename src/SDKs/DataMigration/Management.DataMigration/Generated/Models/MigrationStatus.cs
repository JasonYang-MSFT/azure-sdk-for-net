// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataMigration;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MigrationStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MigrationStatus
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Connecting")]
        Connecting,
        [EnumMember(Value = "SourceAndTargetSelected")]
        SourceAndTargetSelected,
        [EnumMember(Value = "SelectLogins")]
        SelectLogins,
        [EnumMember(Value = "Configured")]
        Configured,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "CompletedWithWarnings")]
        CompletedWithWarnings
    }
    internal static class MigrationStatusEnumExtension
    {
        internal static string ToSerializedValue(this MigrationStatus? value)  =>
            value == null ? null : ((MigrationStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this MigrationStatus value)
        {
            switch( value )
            {
                case MigrationStatus.Default:
                    return "Default";
                case MigrationStatus.Connecting:
                    return "Connecting";
                case MigrationStatus.SourceAndTargetSelected:
                    return "SourceAndTargetSelected";
                case MigrationStatus.SelectLogins:
                    return "SelectLogins";
                case MigrationStatus.Configured:
                    return "Configured";
                case MigrationStatus.Running:
                    return "Running";
                case MigrationStatus.Error:
                    return "Error";
                case MigrationStatus.Cancelled:
                    return "Cancelled";
                case MigrationStatus.Completed:
                    return "Completed";
                case MigrationStatus.CompletedWithWarnings:
                    return "CompletedWithWarnings";
            }
            return null;
        }

        internal static MigrationStatus? ParseMigrationStatus(this string value)
        {
            switch( value )
            {
                case "Default":
                    return MigrationStatus.Default;
                case "Connecting":
                    return MigrationStatus.Connecting;
                case "SourceAndTargetSelected":
                    return MigrationStatus.SourceAndTargetSelected;
                case "SelectLogins":
                    return MigrationStatus.SelectLogins;
                case "Configured":
                    return MigrationStatus.Configured;
                case "Running":
                    return MigrationStatus.Running;
                case "Error":
                    return MigrationStatus.Error;
                case "Cancelled":
                    return MigrationStatus.Cancelled;
                case "Completed":
                    return MigrationStatus.Completed;
                case "CompletedWithWarnings":
                    return MigrationStatus.CompletedWithWarnings;
            }
            return null;
        }
    }
}
