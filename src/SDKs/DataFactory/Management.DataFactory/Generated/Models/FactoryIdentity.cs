// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identity properties of the factory resource.
    /// </summary>
    public partial class FactoryIdentity
    {
        /// <summary>
        /// Initializes a new instance of the FactoryIdentity class.
        /// </summary>
        public FactoryIdentity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryIdentity class.
        /// </summary>
        /// <param name="principalId">The principal id of the identity.</param>
        /// <param name="tenantId">The client tenant id of the
        /// identity.</param>
        public FactoryIdentity(System.Guid? principalId = default(System.Guid?), System.Guid? tenantId = default(System.Guid?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for FactoryIdentity class.
        /// </summary>
        static FactoryIdentity()
        {
            Type = "SystemAssigned";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client tenant id of the identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

        /// <summary>
        /// The identity type. Currently the only supported type is
        /// 'SystemAssigned'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public static string Type { get; private set; }

    }
}
