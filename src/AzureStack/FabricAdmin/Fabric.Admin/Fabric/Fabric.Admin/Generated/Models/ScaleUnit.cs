// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.AzureStack.Management.Fabric.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a cluster - generally this will be a collection of Hosts
    /// backed by Failover Cluster Manager.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScaleUnit : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ScaleUnit class.
        /// </summary>
        public ScaleUnit()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScaleUnit class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="scaleUnitType">Type of the cluster. Possible values
        /// include: 'Unknown', 'ComputeOnly', 'StorageOnly',
        /// 'HyperConverged'</param>
        /// <param name="logicalFaultDomain">Fault domain name of the
        /// cluster.</param>
        /// <param name="nodes">List of nodes in the server.</param>
        /// <param name="state">Current state of the cluster. Possible values
        /// include: 'Unknown', 'Creating', 'Running', 'Upgrading',
        /// 'Deleting'</param>
        /// <param name="model">Model of the servers in the cluster.</param>
        /// <param name="totalCapacity">Capacity information for the
        /// cluster.</param>
        public ScaleUnit(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string scaleUnitType = default(string), int? logicalFaultDomain = default(int?), IList<string> nodes = default(IList<string>), string state = default(string), string model = default(string), ScaleUnitCapacity totalCapacity = default(ScaleUnitCapacity))
            : base(id, name, type, location, tags)
        {
            ScaleUnitType = scaleUnitType;
            LogicalFaultDomain = logicalFaultDomain;
            Nodes = nodes;
            State = state;
            Model = model;
            TotalCapacity = totalCapacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the cluster. Possible values include:
        /// 'Unknown', 'ComputeOnly', 'StorageOnly', 'HyperConverged'
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnitType")]
        public string ScaleUnitType { get; set; }

        /// <summary>
        /// Gets or sets fault domain name of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logicalFaultDomain")]
        public int? LogicalFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets list of nodes in the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nodes")]
        public IList<string> Nodes { get; set; }

        /// <summary>
        /// Gets or sets current state of the cluster. Possible values include:
        /// 'Unknown', 'Creating', 'Running', 'Upgrading', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets model of the servers in the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets capacity information for the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalCapacity")]
        public ScaleUnitCapacity TotalCapacity { get; set; }

    }
}
