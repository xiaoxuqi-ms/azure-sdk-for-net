// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMySqlArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMySqlArmClient"/> class for mocking. </summary>
        protected MockableMySqlArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMySqlArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMySqlArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMySqlArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerResource" /> object. </returns>
        public virtual MySqlServerResource GetMySqlServerResource(ResourceIdentifier id)
        {
            MySqlServerResource.ValidateResourceId(id);
            return new MySqlServerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFirewallRuleResource" /> object. </returns>
        public virtual MySqlFirewallRuleResource GetMySqlFirewallRuleResource(ResourceIdentifier id)
        {
            MySqlFirewallRuleResource.ValidateResourceId(id);
            return new MySqlFirewallRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlVirtualNetworkRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlVirtualNetworkRuleResource.CreateResourceIdentifier" /> to create a <see cref="MySqlVirtualNetworkRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlVirtualNetworkRuleResource" /> object. </returns>
        public virtual MySqlVirtualNetworkRuleResource GetMySqlVirtualNetworkRuleResource(ResourceIdentifier id)
        {
            MySqlVirtualNetworkRuleResource.ValidateResourceId(id);
            return new MySqlVirtualNetworkRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="MySqlDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlDatabaseResource" /> object. </returns>
        public virtual MySqlDatabaseResource GetMySqlDatabaseResource(ResourceIdentifier id)
        {
            MySqlDatabaseResource.ValidateResourceId(id);
            return new MySqlDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MySqlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlConfigurationResource" /> object. </returns>
        public virtual MySqlConfigurationResource GetMySqlConfigurationResource(ResourceIdentifier id)
        {
            MySqlConfigurationResource.ValidateResourceId(id);
            return new MySqlConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerAdministratorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerAdministratorResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerAdministratorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerAdministratorResource" /> object. </returns>
        public virtual MySqlServerAdministratorResource GetMySqlServerAdministratorResource(ResourceIdentifier id)
        {
            MySqlServerAdministratorResource.ValidateResourceId(id);
            return new MySqlServerAdministratorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerSecurityAlertPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerSecurityAlertPolicyResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerSecurityAlertPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerSecurityAlertPolicyResource" /> object. </returns>
        public virtual MySqlServerSecurityAlertPolicyResource GetMySqlServerSecurityAlertPolicyResource(ResourceIdentifier id)
        {
            MySqlServerSecurityAlertPolicyResource.ValidateResourceId(id);
            return new MySqlServerSecurityAlertPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlQueryTextResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlQueryTextResource.CreateResourceIdentifier" /> to create a <see cref="MySqlQueryTextResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlQueryTextResource" /> object. </returns>
        public virtual MySqlQueryTextResource GetMySqlQueryTextResource(ResourceIdentifier id)
        {
            MySqlQueryTextResource.ValidateResourceId(id);
            return new MySqlQueryTextResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlQueryStatisticResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlQueryStatisticResource.CreateResourceIdentifier" /> to create a <see cref="MySqlQueryStatisticResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlQueryStatisticResource" /> object. </returns>
        public virtual MySqlQueryStatisticResource GetMySqlQueryStatisticResource(ResourceIdentifier id)
        {
            MySqlQueryStatisticResource.ValidateResourceId(id);
            return new MySqlQueryStatisticResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlWaitStatisticResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlWaitStatisticResource.CreateResourceIdentifier" /> to create a <see cref="MySqlWaitStatisticResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlWaitStatisticResource" /> object. </returns>
        public virtual MySqlWaitStatisticResource GetMySqlWaitStatisticResource(ResourceIdentifier id)
        {
            MySqlWaitStatisticResource.ValidateResourceId(id);
            return new MySqlWaitStatisticResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlAdvisorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlAdvisorResource.CreateResourceIdentifier" /> to create a <see cref="MySqlAdvisorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlAdvisorResource" /> object. </returns>
        public virtual MySqlAdvisorResource GetMySqlAdvisorResource(ResourceIdentifier id)
        {
            MySqlAdvisorResource.ValidateResourceId(id);
            return new MySqlAdvisorResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlRecommendationActionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlRecommendationActionResource.CreateResourceIdentifier" /> to create a <see cref="MySqlRecommendationActionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlRecommendationActionResource" /> object. </returns>
        public virtual MySqlRecommendationActionResource GetMySqlRecommendationActionResource(ResourceIdentifier id)
        {
            MySqlRecommendationActionResource.ValidateResourceId(id);
            return new MySqlRecommendationActionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MySqlPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlPrivateEndpointConnectionResource" /> object. </returns>
        public virtual MySqlPrivateEndpointConnectionResource GetMySqlPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            MySqlPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new MySqlPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="MySqlPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlPrivateLinkResource" /> object. </returns>
        public virtual MySqlPrivateLinkResource GetMySqlPrivateLinkResource(ResourceIdentifier id)
        {
            MySqlPrivateLinkResource.ValidateResourceId(id);
            return new MySqlPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerKeyResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerKeyResource" /> object. </returns>
        public virtual MySqlServerKeyResource GetMySqlServerKeyResource(ResourceIdentifier id)
        {
            MySqlServerKeyResource.ValidateResourceId(id);
            return new MySqlServerKeyResource(Client, id);
        }
    }
}
