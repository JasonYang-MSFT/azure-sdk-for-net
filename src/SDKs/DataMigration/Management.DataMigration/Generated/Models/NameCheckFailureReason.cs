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
    /// Defines values for NameCheckFailureReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameCheckFailureReason
    {
        [EnumMember(Value = "AlreadyExists")]
        AlreadyExists,
        [EnumMember(Value = "Invalid")]
        Invalid
    }
    internal static class NameCheckFailureReasonEnumExtension
    {
        internal static string ToSerializedValue(this NameCheckFailureReason? value)  =>
            value == null ? null : ((NameCheckFailureReason)value).ToSerializedValue();

        internal static string ToSerializedValue(this NameCheckFailureReason value)
        {
            switch( value )
            {
                case NameCheckFailureReason.AlreadyExists:
                    return "AlreadyExists";
                case NameCheckFailureReason.Invalid:
                    return "Invalid";
            }
            return null;
        }

        internal static NameCheckFailureReason? ParseNameCheckFailureReason(this string value)
        {
            switch( value )
            {
                case "AlreadyExists":
                    return NameCheckFailureReason.AlreadyExists;
                case "Invalid":
                    return NameCheckFailureReason.Invalid;
            }
            return null;
        }
    }
}
