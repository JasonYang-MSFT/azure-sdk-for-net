// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AzureRegions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AzureRegions
    {
        [EnumMember(Value = "westus")]
        Westus,
        [EnumMember(Value = "westeurope")]
        Westeurope,
        [EnumMember(Value = "southeastasia")]
        Southeastasia,
        [EnumMember(Value = "eastus2")]
        Eastus2,
        [EnumMember(Value = "westcentralus")]
        Westcentralus
    }
    internal static class AzureRegionsEnumExtension
    {
        internal static string ToSerializedValue(this AzureRegions? value)  =>
            value == null ? null : ((AzureRegions)value).ToSerializedValue();

        internal static string ToSerializedValue(this AzureRegions value)
        {
            switch( value )
            {
                case AzureRegions.Westus:
                    return "westus";
                case AzureRegions.Westeurope:
                    return "westeurope";
                case AzureRegions.Southeastasia:
                    return "southeastasia";
                case AzureRegions.Eastus2:
                    return "eastus2";
                case AzureRegions.Westcentralus:
                    return "westcentralus";
            }
            return null;
        }

        internal static AzureRegions? ParseAzureRegions(this string value)
        {
            switch( value )
            {
                case "westus":
                    return AzureRegions.Westus;
                case "westeurope":
                    return AzureRegions.Westeurope;
                case "southeastasia":
                    return AzureRegions.Southeastasia;
                case "eastus2":
                    return AzureRegions.Eastus2;
                case "westcentralus":
                    return AzureRegions.Westcentralus;
            }
            return null;
        }
    }
}
