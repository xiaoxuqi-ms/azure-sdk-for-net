// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ProviderHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A Class representing a ProviderRegistration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ProviderRegistrationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetProviderRegistrationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetProviderRegistration method.
    /// </summary>
    public partial class ProviderRegistrationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ProviderRegistrationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="providerNamespace"> The providerNamespace. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerNamespace)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _providerRegistrationClientDiagnostics;
        private readonly ProviderRegistrationsRestOperations _providerRegistrationRestClient;
        private readonly ClientDiagnostics _defaultClientDiagnostics;
        private readonly ProviderHubRestOperations _defaultRestClient;
        private readonly ProviderRegistrationData _data;

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResource"/> class for mocking. </summary>
        protected ProviderRegistrationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ProviderRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ProviderRegistrationResource(ArmClient client, ProviderRegistrationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ProviderRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProviderRegistrationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string providerRegistrationApiVersion);
            _providerRegistrationRestClient = new ProviderRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, providerRegistrationApiVersion);
            _defaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _defaultRestClient = new ProviderHubRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ProviderHub/providerRegistrations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProviderRegistrationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of CustomRolloutResources in the ProviderRegistration. </summary>
        /// <returns> An object representing collection of CustomRolloutResources and their operations over a CustomRolloutResource. </returns>
        public virtual CustomRolloutCollection GetCustomRollouts()
        {
            return GetCachedClient(client => new CustomRolloutCollection(client, Id));
        }

        /// <summary>
        /// Gets the custom rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<CustomRolloutResource>> GetCustomRolloutAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            return await GetCustomRollouts().GetAsync(rolloutName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the custom rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/customRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<CustomRolloutResource> GetCustomRollout(string rolloutName, CancellationToken cancellationToken = default)
        {
            return GetCustomRollouts().Get(rolloutName, cancellationToken);
        }

        /// <summary> Gets a collection of DefaultRolloutResources in the ProviderRegistration. </summary>
        /// <returns> An object representing collection of DefaultRolloutResources and their operations over a DefaultRolloutResource. </returns>
        public virtual DefaultRolloutCollection GetDefaultRollouts()
        {
            return GetCachedClient(client => new DefaultRolloutCollection(client, Id));
        }

        /// <summary>
        /// Gets the default rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DefaultRolloutResource>> GetDefaultRolloutAsync(string rolloutName, CancellationToken cancellationToken = default)
        {
            return await GetDefaultRollouts().GetAsync(rolloutName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the default rollout details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/defaultRollouts/{rolloutName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DefaultRollouts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rolloutName"> The rollout name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rolloutName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="rolloutName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DefaultRolloutResource> GetDefaultRollout(string rolloutName, CancellationToken cancellationToken = default)
        {
            return GetDefaultRollouts().Get(rolloutName, cancellationToken);
        }

        /// <summary> Gets a collection of NotificationRegistrationResources in the ProviderRegistration. </summary>
        /// <returns> An object representing collection of NotificationRegistrationResources and their operations over a NotificationRegistrationResource. </returns>
        public virtual NotificationRegistrationCollection GetNotificationRegistrations()
        {
            return GetCachedClient(client => new NotificationRegistrationCollection(client, Id));
        }

        /// <summary>
        /// Gets the notification registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NotificationRegistrationResource>> GetNotificationRegistrationAsync(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            return await GetNotificationRegistrations().GetAsync(notificationRegistrationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the notification registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NotificationRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="notificationRegistrationName"> The notification registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notificationRegistrationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="notificationRegistrationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NotificationRegistrationResource> GetNotificationRegistration(string notificationRegistrationName, CancellationToken cancellationToken = default)
        {
            return GetNotificationRegistrations().Get(notificationRegistrationName, cancellationToken);
        }

        /// <summary> Gets a collection of ResourceTypeRegistrationResources in the ProviderRegistration. </summary>
        /// <returns> An object representing collection of ResourceTypeRegistrationResources and their operations over a ResourceTypeRegistrationResource. </returns>
        public virtual ResourceTypeRegistrationCollection GetResourceTypeRegistrations()
        {
            return GetCachedClient(client => new ResourceTypeRegistrationCollection(client, Id));
        }

        /// <summary>
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourceTypeRegistrationResource>> GetResourceTypeRegistrationAsync(string resourceType, CancellationToken cancellationToken = default)
        {
            return await GetResourceTypeRegistrations().GetAsync(resourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a resource type details in the given subscription and provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/resourcetypeRegistrations/{resourceType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceTypeRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceType"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourceTypeRegistrationResource> GetResourceTypeRegistration(string resourceType, CancellationToken cancellationToken = default)
        {
            return GetResourceTypeRegistrations().Get(resourceType, cancellationToken);
        }

        /// <summary>
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProviderRegistrationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the provider registration details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProviderRegistrationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProviderRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new ProviderHubArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The provider registration properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ProviderRegistrationResource>> UpdateAsync(WaitUntil waitUntil, ProviderRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = await _providerRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResource>(new ProviderRegistrationOperationSource(Client), _providerRegistrationClientDiagnostics, Pipeline, _providerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the provider registration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderRegistrations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The provider registration properties supplied to the CreateOrUpdate operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ProviderRegistrationResource> Update(WaitUntil waitUntil, ProviderRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _providerRegistrationClientDiagnostics.CreateScope("ProviderRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = _providerRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new ProviderHubArmOperation<ProviderRegistrationResource>(new ProviderRegistrationOperationSource(Client), _providerRegistrationClientDiagnostics, Pipeline, _providerRegistrationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generates the manifest for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/generateManifest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GenerateManifest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceProviderManifest>> GenerateManifestAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _defaultClientDiagnostics.CreateScope("ProviderRegistrationResource.GenerateManifest");
            scope.Start();
            try
            {
                var response = await _defaultRestClient.GenerateManifestAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generates the manifest for the given provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/generateManifest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GenerateManifest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceProviderManifest> GenerateManifest(CancellationToken cancellationToken = default)
        {
            using var scope = _defaultClientDiagnostics.CreateScope("ProviderRegistrationResource.GenerateManifest");
            scope.Start();
            try
            {
                var response = _defaultRestClient.GenerateManifest(Id.SubscriptionId, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checkin the manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/checkinManifest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckinManifest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required body parameters supplied to the checkin manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CheckinManifestInfo>> CheckinManifestAsync(CheckinManifestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _defaultClientDiagnostics.CreateScope("ProviderRegistrationResource.CheckinManifest");
            scope.Start();
            try
            {
                var response = await _defaultRestClient.CheckinManifestAsync(Id.SubscriptionId, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checkin the manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/checkinManifest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckinManifest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required body parameters supplied to the checkin manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CheckinManifestInfo> CheckinManifest(CheckinManifestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _defaultClientDiagnostics.CreateScope("ProviderRegistrationResource.CheckinManifest");
            scope.Start();
            try
            {
                var response = _defaultRestClient.CheckinManifest(Id.SubscriptionId, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
