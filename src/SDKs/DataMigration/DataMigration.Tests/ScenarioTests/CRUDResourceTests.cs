// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using DataMigration.Tests.Helpers;
using Microsoft.Azure.Management.DataMigration;
using Microsoft.Azure.Management.DataMigration.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Net;
using Xunit;

namespace DataMigration.Tests.ScenarioTests
{
    public class CRUDResourceTests : TestBase
    {
        private const string Location = "westus2";
        private const string ResourceGroupName = "dmssdkrg";
        private const string DmsDeploymentName = "dmssdk";

        [Fact]
        public void CreateResourceSucceeds()
        {
            var dmsClientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, Location);
                var dmsClient = Utilities.GetDataMigrationManagementClient(context, dmsClientHandler);
                var createResult = CreateDMSInstance(context, dmsClient, resourceGroup, DmsDeploymentName);
            }
        }
        
        private DataMigrationService CreateDMSInstance(MockContext context,
            DataMigrationServiceClient client, 
            ResourceGroup resourceGroup, 
            string dmsInstanceName)
        {
            return client.Services.CreateOrUpdate(new DataMigrationService(
                type: "Microsoft.DataMigration/services",
                location: resourceGroup.Location,
                virtualSubnetId: "/subscriptions/97181df2-909d-420b-ab93-1bff15acb6b7/resourceGroups/ERNetwork/providers/Microsoft.Network/virtualNetworks/AzureDMS-CORP-WUS2-VNET-5129/subnets/Subnet-1",
                sku: new ServiceSku("PP1")),
                    resourceGroup.Name,
                    dmsInstanceName);

            //JObject json = JObject.Parse(handler.Request);

            // Validate headers
            //Assert.Equal(HttpMethod.Put, handler.Method);
            //Assert.NotNull(handler.RequestHeaders.GetValues("Authorization"));

            // Validate payload
            //Assert.Equal("westus2", json["location"].Value<string>());
            //Assert.Equal("PP1", json["sku"]["name"].Value<string>());
            //Assert.Equal("/subscriptions/97181df2-909d-420b-ab93-1bff15acb6b7/resourceGroups/ERNetwork/providers/Microsoft.Network/virtualNetworks/AzureDMS-CORP-WUS2-VNET-5129/subnets/Subnet-1", json["properties"]["virtualSubnetId"].Value<string>());

            //// Validate result
            //Assert.Equal("westus2", createResult.Location);
            //Assert.Equal("/subscriptions/97181df2-909d-420b-ab93-1bff15acb6b7/resourceGroups/dmssdktestrg/providers/Microsoft.DataMigration/services/dmssdktestinstance", createResult.Id);
            //Assert.Equal("vm", createResult.Kind);
            //Assert.Equal("dmssdktestinstance", createResult.Name);
            //Assert.Equal(ServiceProvisioningState.Succeeded, createResult.ProvisioningState);
            //Assert.Equal("PP1", createResult.Sku.Name);
            //Assert.Equal("Microsoft.DataMigration/services", createResult.Type);
            //Assert.Equal("/subscriptions/97181df2-909d-420b-ab93-1bff15acb6b7/resourceGroups/ERNetwork/providers/Microsoft.Network/virtualNetworks/AzureDMS-CORP-WUS2-VNET-5129/subnets/Subnet-1", createResult.VirtualSubnetId);
        }

        private ResourceGroup CreateResourceGroup(MockContext context, 
            RecordedDelegatingHandler handler,
            string resourceGroupName, 
            string location)
        {
            var resourcesClient =
                Utilities.GetResourceManagementClient(
                    context,
                    handler);

            var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                resourceGroupName,
                new ResourceGroup
                {
                    Location = location
                });
                
            return resourceGroup;
        }

        [Fact]
        public void GetResourceSucceeds()
        {
            var dmsClientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, Location);
                var dmsClient = Utilities.GetDataMigrationManagementClient(context, dmsClientHandler);
                var createResult = CreateDMSInstance(context, dmsClient, resourceGroup, DmsDeploymentName);
                var getResult = dmsClient.Services.Get(resourceGroup.Name, DmsDeploymentName);
            }
        }
        
        [Fact]
        public void DeleteResourceSucceeds()
        {
            var dmsClientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, Location);
                var dmsClient = Utilities.GetDataMigrationManagementClient(context, dmsClientHandler);
                var createResult = CreateDMSInstance(context, dmsClient, resourceGroup, DmsDeploymentName);
                var getResult = dmsClient.Services.Get(resourceGroup.Name, DmsDeploymentName);
                dmsClient.Services.Delete(resourceGroup.Name, DmsDeploymentName);
                
                var x = Assert.Throws<ApiErrorException>(() => dmsClient.Services.Get(ResourceGroupName, DmsDeploymentName));
                Assert.Equal(HttpStatusCode.NotFound, x.Response.StatusCode);
            }
        }
    }
}
