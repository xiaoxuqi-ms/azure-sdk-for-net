// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerRegistry.Mocking;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ContainerRegistry. </summary>
    public static partial class ContainerRegistryExtensions
    {
        private static MockableContainerRegistryArmClient GetMockableContainerRegistryArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableContainerRegistryArmClient(client0));
        }

        private static MockableContainerRegistryResourceGroupResource GetMockableContainerRegistryResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableContainerRegistryResourceGroupResource(client, resource.Id));
        }

        private static MockableContainerRegistrySubscriptionResource GetMockableContainerRegistrySubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableContainerRegistrySubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryResource" /> object. </returns>
        public static ContainerRegistryResource GetContainerRegistryResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryPrivateLinkResource" /> object. </returns>
        public static ContainerRegistryPrivateLinkResource GetContainerRegistryPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryPrivateEndpointConnectionResource" /> object. </returns>
        public static ContainerRegistryPrivateEndpointConnectionResource GetContainerRegistryPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryReplicationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryReplicationResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryReplicationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryReplicationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryReplicationResource" /> object. </returns>
        public static ContainerRegistryReplicationResource GetContainerRegistryReplicationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryReplicationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ScopeMapResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScopeMapResource.CreateResourceIdentifier" /> to create a <see cref="ScopeMapResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetScopeMapResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScopeMapResource" /> object. </returns>
        public static ScopeMapResource GetScopeMapResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetScopeMapResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryTokenResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryTokenResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryTokenResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryTokenResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryTokenResource" /> object. </returns>
        public static ContainerRegistryTokenResource GetContainerRegistryTokenResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryTokenResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryWebhookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryWebhookResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryWebhookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryWebhookResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryWebhookResource" /> object. </returns>
        public static ContainerRegistryWebhookResource GetContainerRegistryWebhookResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryWebhookResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryAgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryAgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryAgentPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryAgentPoolResource" /> object. </returns>
        public static ContainerRegistryAgentPoolResource GetContainerRegistryAgentPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryAgentPoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryRunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryRunResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryRunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryRunResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryRunResource" /> object. </returns>
        public static ContainerRegistryRunResource GetContainerRegistryRunResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryRunResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryTaskRunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryTaskRunResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryTaskRunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryTaskRunResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryTaskRunResource" /> object. </returns>
        public static ContainerRegistryTaskRunResource GetContainerRegistryTaskRunResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryTaskRunResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerRegistryTaskResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerRegistryTaskResource.CreateResourceIdentifier" /> to create a <see cref="ContainerRegistryTaskResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryArmClient.GetContainerRegistryTaskResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerRegistryTaskResource" /> object. </returns>
        public static ContainerRegistryTaskResource GetContainerRegistryTaskResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableContainerRegistryArmClient(client).GetContainerRegistryTaskResource(id);
        }

        /// <summary>
        /// Gets a collection of ContainerRegistryResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryResourceGroupResource.GetContainerRegistries()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ContainerRegistryResources and their operations over a ContainerRegistryResource. </returns>
        public static ContainerRegistryCollection GetContainerRegistries(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableContainerRegistryResourceGroupResource(resourceGroupResource).GetContainerRegistries();
        }

        /// <summary>
        /// Gets the properties of the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryResourceGroupResource.GetContainerRegistryAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ContainerRegistryResource>> GetContainerRegistryAsync(this ResourceGroupResource resourceGroupResource, string registryName, CancellationToken cancellationToken = default)
        {
            return await GetMockableContainerRegistryResourceGroupResource(resourceGroupResource).GetContainerRegistryAsync(registryName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistryResourceGroupResource.GetContainerRegistry(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="registryName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ContainerRegistryResource> GetContainerRegistry(this ResourceGroupResource resourceGroupResource, string registryName, CancellationToken cancellationToken = default)
        {
            return GetMockableContainerRegistryResourceGroupResource(resourceGroupResource).GetContainerRegistry(registryName, cancellationToken);
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistrySubscriptionResource.CheckContainerRegistryNameAvailability(ContainerRegistryNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ContainerRegistryNameAvailableResult>> CheckContainerRegistryNameAvailabilityAsync(this SubscriptionResource subscriptionResource, ContainerRegistryNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableContainerRegistrySubscriptionResource(subscriptionResource).CheckContainerRegistryNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistrySubscriptionResource.CheckContainerRegistryNameAvailability(ContainerRegistryNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ContainerRegistryNameAvailableResult> CheckContainerRegistryNameAvailability(this SubscriptionResource subscriptionResource, ContainerRegistryNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableContainerRegistrySubscriptionResource(subscriptionResource).CheckContainerRegistryNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistrySubscriptionResource.GetContainerRegistries(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContainerRegistryResource> GetContainerRegistriesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableContainerRegistrySubscriptionResource(subscriptionResource).GetContainerRegistriesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerRegistrySubscriptionResource.GetContainerRegistries(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContainerRegistryResource> GetContainerRegistries(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableContainerRegistrySubscriptionResource(subscriptionResource).GetContainerRegistries(cancellationToken);
        }
    }
}
