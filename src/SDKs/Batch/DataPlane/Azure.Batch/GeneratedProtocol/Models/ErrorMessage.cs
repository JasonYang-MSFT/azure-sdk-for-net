// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An error message received in an Azure Batch error response.
    /// </summary>
    public partial class ErrorMessage
    {
        /// <summary>
        /// Initializes a new instance of the ErrorMessage class.
        /// </summary>
        public ErrorMessage()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorMessage class.
        /// </summary>
        /// <param name="lang">The language code of the error message</param>
        /// <param name="value">The text of the message.</param>
        public ErrorMessage(string lang = default(string), string value = default(string))
        {
            Lang = lang;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the language code of the error message
        /// </summary>
        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets the text of the message.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
