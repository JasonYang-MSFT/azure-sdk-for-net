// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Virtual Network information contract.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetInfo : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetInfo class.
        /// </summary>
        public VnetInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetInfo class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="vnetResourceId">The Virtual Network's resource
        /// ID.</param>
        /// <param name="certThumbprint">The client certificate
        /// thumbprint.</param>
        /// <param name="certBlob">A certificate file (.cer) blob containing
        /// the public key of the private key used to authenticate a
        /// Point-To-Site VPN connection.</param>
        /// <param name="routes">The routes that this Virtual Network
        /// connection uses.</param>
        /// <param name="resyncRequired">&lt;code&gt;true&lt;/code&gt; if a
        /// resync is required; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="dnsServers">DNS servers to be used by this Virtual
        /// Network. This should be a comma-separated list of IP
        /// addresses.</param>
        public VnetInfo(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string vnetResourceId = default(string), string certThumbprint = default(string), string certBlob = default(string), IList<VnetRoute> routes = default(IList<VnetRoute>), bool? resyncRequired = default(bool?), string dnsServers = default(string))
            : base(id, name, kind, type)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprint = certThumbprint;
            CertBlob = certBlob;
            Routes = routes;
            ResyncRequired = resyncRequired;
            DnsServers = dnsServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Virtual Network's resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetResourceId")]
        public string VnetResourceId { get; set; }

        /// <summary>
        /// Gets the client certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certThumbprint")]
        public string CertThumbprint { get; private set; }

        /// <summary>
        /// Gets or sets a certificate file (.cer) blob containing the public
        /// key of the private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certBlob")]
        public string CertBlob { get; set; }

        /// <summary>
        /// Gets the routes that this Virtual Network connection uses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routes")]
        public IList<VnetRoute> Routes { get; private set; }

        /// <summary>
        /// Gets &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; if a resync is
        /// required; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resyncRequired")]
        public bool? ResyncRequired { get; private set; }

        /// <summary>
        /// Gets or sets DNS servers to be used by this Virtual Network. This
        /// should be a comma-separated list of IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsServers")]
        public string DnsServers { get; set; }

    }
}
