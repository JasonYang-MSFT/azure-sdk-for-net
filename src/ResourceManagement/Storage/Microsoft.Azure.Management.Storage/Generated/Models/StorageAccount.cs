// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The storage account.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Tags assigned to a resource; can be used for
        /// viewing and grouping a resource (across resource groups).</param>
        /// <param name="sku">Gets the SKU.</param>
        /// <param name="kind">Gets the Kind. Possible values include:
        /// 'Storage', 'BlobStorage', 'TableStorage'</param>
        /// <param name="provisioningState">Gets the status of the storage
        /// account at the time the operation was called. Possible values
        /// include: 'Creating', 'ResolvingDNS', 'Succeeded'</param>
        /// <param name="primaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object. Note
        /// that Standard_ZRS and Premium_LRS accounts only return the blob
        /// endpoint.</param>
        /// <param name="primaryLocation">Gets the location of the primary data
        /// center for the storage account.</param>
        /// <param name="statusOfPrimary">Gets the status indicating whether
        /// the primary location of the storage account is available or
        /// unavailable. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="lastGeoFailoverTime">Gets the timestamp of the most
        /// recent instance of a failover to the secondary location. Only the
        /// most recent timestamp is retained. This element is not returned if
        /// there has never been a failover instance. Only available if the
        /// accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="secondaryLocation">Gets the location of the
        /// geo-replicated secondary for the storage account. Only available if
        /// the accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="statusOfSecondary">Gets the status indicating whether
        /// the secondary location of the storage account is available or
        /// unavailable. Only available if the SKU name is Standard_GRS or
        /// Standard_RAGRS. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="creationTime">Gets the creation date and time of the
        /// storage account in UTC.</param>
        /// <param name="customDomain">Gets the custom domain the user assigned
        /// to this storage account.</param>
        /// <param name="secondaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object from
        /// the secondary location of the storage account. Only available if
        /// the SKU name is Standard_RAGRS.</param>
        /// <param name="encryption">Gets the encryption settings on the
        /// account. If unspecified, the account is unencrypted.</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="supportsHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true.</param>
        public StorageAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Kind? kind = default(Kind?), ProvisioningState? provisioningState = default(ProvisioningState?), Endpoints primaryEndpoints = default(Endpoints), string primaryLocation = default(string), AccountStatus? statusOfPrimary = default(AccountStatus?), System.DateTime? lastGeoFailoverTime = default(System.DateTime?), string secondaryLocation = default(string), AccountStatus? statusOfSecondary = default(AccountStatus?), System.DateTime? creationTime = default(System.DateTime?), CustomDomain customDomain = default(CustomDomain), Endpoints secondaryEndpoints = default(Endpoints), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?), bool? supportsHttpsTrafficOnly = default(bool?), StorageNetworkRules networkAcls = default(StorageNetworkRules))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            Kind = kind;
            ProvisioningState = provisioningState;
            PrimaryEndpoints = primaryEndpoints;
            PrimaryLocation = primaryLocation;
            StatusOfPrimary = statusOfPrimary;
            LastGeoFailoverTime = lastGeoFailoverTime;
            SecondaryLocation = secondaryLocation;
            StatusOfSecondary = statusOfSecondary;
            CreationTime = creationTime;
            CustomDomain = customDomain;
            SecondaryEndpoints = secondaryEndpoints;
            Encryption = encryption;
            AccessTier = accessTier;
            SupportsHttpsTrafficOnly = supportsHttpsTrafficOnly;
            NetworkAcls = networkAcls;
        }

        /// <summary>
        /// Gets the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; protected set; }

        /// <summary>
        /// Gets the Kind. Possible values include: 'Storage', 'BlobStorage',
        /// 'TableStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind? Kind { get; protected set; }

        /// <summary>
        /// Gets the status of the storage account at the time the operation
        /// was called. Possible values include: 'Creating', 'ResolvingDNS',
        /// 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object. Note that Standard_ZRS and
        /// Premium_LRS accounts only return the blob endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryEndpoints")]
        public Endpoints PrimaryEndpoints { get; protected set; }

        /// <summary>
        /// Gets the location of the primary data center for the storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryLocation")]
        public string PrimaryLocation { get; protected set; }

        /// <summary>
        /// Gets the status indicating whether the primary location of the
        /// storage account is available or unavailable. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfPrimary")]
        public AccountStatus? StatusOfPrimary { get; protected set; }

        /// <summary>
        /// Gets the timestamp of the most recent instance of a failover to the
        /// secondary location. Only the most recent timestamp is retained.
        /// This element is not returned if there has never been a failover
        /// instance. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastGeoFailoverTime")]
        public System.DateTime? LastGeoFailoverTime { get; protected set; }

        /// <summary>
        /// Gets the location of the geo-replicated secondary for the storage
        /// account. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryLocation")]
        public string SecondaryLocation { get; protected set; }

        /// <summary>
        /// Gets the status indicating whether the secondary location of the
        /// storage account is available or unavailable. Only available if the
        /// SKU name is Standard_GRS or Standard_RAGRS. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfSecondary")]
        public AccountStatus? StatusOfSecondary { get; protected set; }

        /// <summary>
        /// Gets the creation date and time of the storage account in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; protected set; }

        /// <summary>
        /// Gets the custom domain the user assigned to this storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; protected set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object from the secondary location of the
        /// storage account. Only available if the SKU name is Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryEndpoints")]
        public Endpoints SecondaryEndpoints { get; protected set; }

        /// <summary>
        /// Gets the encryption settings on the account. If unspecified, the
        /// account is unencrypted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; protected set; }

        /// <summary>
        /// Gets required for storage accounts where kind = BlobStorage. The
        /// access tier used for billing. Possible values include: 'Hot',
        /// 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; protected set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? SupportsHttpsTrafficOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public StorageNetworkRules NetworkAcls { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
            if (NetworkAcls != null)
            {
                NetworkAcls.Validate();
            }
        }
    }
}

