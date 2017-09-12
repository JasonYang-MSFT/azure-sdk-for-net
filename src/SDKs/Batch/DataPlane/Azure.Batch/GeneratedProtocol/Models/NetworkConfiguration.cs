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
    /// The network configuration for a pool.
    /// </summary>
    public partial class NetworkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        public NetworkConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        /// <param name="subnetId">The ARM resource identifier of the virtual
        /// network subnet which the compute nodes of the pool will join. This
        /// is of the form
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/{provider}/virtualNetworks/{network}/subnets/{subnet}.</param>
        /// <param name="endpointConfiguration">The configuration for endpoints
        /// on compute nodes in the Batch pool.</param>
        public NetworkConfiguration(string subnetId = default(string), PoolEndpointConfiguration endpointConfiguration = default(PoolEndpointConfiguration))
        {
            SubnetId = subnetId;
            EndpointConfiguration = endpointConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual network
        /// subnet which the compute nodes of the pool will join. This is of
        /// the form
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/{provider}/virtualNetworks/{network}/subnets/{subnet}.
        /// </summary>
        /// <remarks>
        /// The virtual network must be in the same region and subscription as
        /// the Azure Batch account. The specified subnet should have enough
        /// free IP addresses to accommodate the number of nodes in the pool.
        /// If the subnet doesn't have enough free IP addresses, the pool will
        /// partially allocate compute nodes, and a resize error will occur.
        /// The 'MicrosoftAzureBatch' service principal must have the 'Classic
        /// Virtual Machine Contributor' Role-Based Access Control (RBAC) role
        /// for the specified VNet. The specified subnet must allow
        /// communication from the Azure Batch service to be able to schedule
        /// tasks on the compute nodes. This can be verified by checking if the
        /// specified VNet has any associated Network Security Groups (NSG). If
        /// communication to the compute nodes in the specified subnet is
        /// denied by an NSG, then the Batch service will set the state of the
        /// compute nodes to unusable. For pools created with
        /// virtualMachineConfiguration only ARM virtual networks
        /// ('Microsoft.Network/virtualNetworks') are supported, but for pools
        /// created with cloudServiceConfiguration both ARM and classic virtual
        /// networks are supported. If the specified VNet has any associated
        /// Network Security Groups (NSG), then a few reserved system ports
        /// must be enabled for inbound communication. For pools created with a
        /// virtual machine configuration, enable ports 29876 and 29877, as
        /// well as port 22 for Linux and port 3389 for Windows. For pools
        /// created with a cloud service configuration, enable ports 10100,
        /// 20100, and 30100. Also enable outbound connections to Azure Storage
        /// on port 443. For more details see:
        /// https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration
        /// </remarks>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets the configuration for endpoints on compute nodes in
        /// the Batch pool.
        /// </summary>
        /// <remarks>
        /// Pool endpoint configuration is only supported on pools with the
        /// virtualMachineConfiguration property.
        /// </remarks>
        [JsonProperty(PropertyName = "endpointConfiguration")]
        public PoolEndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndpointConfiguration != null)
            {
                EndpointConfiguration.Validate();
            }
        }
    }
}
