// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A Class representing a MediaAsset along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MediaAssetResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMediaAssetResource method.
    /// Otherwise you can get one from its parent resource <see cref="MediaServicesAccountResource" /> using the GetMediaAsset method.
    /// </summary>
    public partial class MediaAssetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MediaAssetResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="assetName"> The assetName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string assetName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mediaAssetAssetsClientDiagnostics;
        private readonly AssetsRestOperations _mediaAssetAssetsRestClient;
        private readonly MediaAssetData _data;

        /// <summary> Initializes a new instance of the <see cref="MediaAssetResource"/> class for mocking. </summary>
        protected MediaAssetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MediaAssetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MediaAssetResource(ArmClient client, MediaAssetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MediaAssetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaAssetAssetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mediaAssetAssetsApiVersion);
            _mediaAssetAssetsRestClient = new AssetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaAssetAssetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Media/mediaServices/assets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MediaAssetData Data
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

        /// <summary> Gets a collection of MediaAssetFilterResources in the MediaAsset. </summary>
        /// <returns> An object representing collection of MediaAssetFilterResources and their operations over a MediaAssetFilterResource. </returns>
        public virtual MediaAssetFilterCollection GetMediaAssetFilters()
        {
            return GetCachedClient(client => new MediaAssetFilterCollection(client, Id));
        }

        /// <summary>
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MediaAssetFilterResource>> GetMediaAssetFilterAsync(string filterName, CancellationToken cancellationToken = default)
        {
            return await GetMediaAssetFilters().GetAsync(filterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filterName"> The Asset Filter name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="filterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MediaAssetFilterResource> GetMediaAssetFilter(string filterName, CancellationToken cancellationToken = default)
        {
            return GetMediaAssetFilters().Get(filterName, cancellationToken);
        }

        /// <summary> Gets a collection of MediaAssetTrackResources in the MediaAsset. </summary>
        /// <returns> An object representing collection of MediaAssetTrackResources and their operations over a MediaAssetTrackResource. </returns>
        public virtual MediaAssetTrackCollection GetMediaAssetTracks()
        {
            return GetCachedClient(client => new MediaAssetTrackCollection(client, Id));
        }

        /// <summary>
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MediaAssetTrackResource>> GetMediaAssetTrackAsync(string trackName, CancellationToken cancellationToken = default)
        {
            return await GetMediaAssetTracks().GetAsync(trackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trackName"> The Asset Track name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="trackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MediaAssetTrackResource> GetMediaAssetTrack(string trackName, CancellationToken cancellationToken = default)
        {
            return GetMediaAssetTracks().Get(trackName, cancellationToken);
        }

        /// <summary>
        /// Get the details of an Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaAssetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Get");
            scope.Start();
            try
            {
                var response = await _mediaAssetAssetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaAssetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Get");
            scope.Start();
            try
            {
                var response = _mediaAssetAssetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Delete");
            scope.Start();
            try
            {
                var response = await _mediaAssetAssetsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation(response);
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
        /// Deletes an Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Delete");
            scope.Start();
            try
            {
                var response = _mediaAssetAssetsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MediaArmOperation(response);
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
        /// Updates an existing Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<MediaAssetResource>> UpdateAsync(MediaAssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Update");
            scope.Start();
            try
            {
                var response = await _mediaAssetAssetsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MediaAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing Asset in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<MediaAssetResource> Update(MediaAssetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.Update");
            scope.Start();
            try
            {
                var response = _mediaAssetAssetsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new MediaAssetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists storage container URLs with shared access signatures (SAS) for uploading and downloading Asset content. The signatures are derived from the storage account keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/listContainerSas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_ListContainerSas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="Uri" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Uri> GetStorageContainerUrisAsync(MediaAssetStorageContainerSasContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetAssetsRestClient.CreateListContainerSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new Uri(e.GetString()), _mediaAssetAssetsClientDiagnostics, Pipeline, "MediaAssetResource.GetStorageContainerUris", "assetContainerSasUrls", null, cancellationToken);
        }

        /// <summary>
        /// Lists storage container URLs with shared access signatures (SAS) for uploading and downloading Asset content. The signatures are derived from the storage account keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/listContainerSas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_ListContainerSas</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="Uri" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Uri> GetStorageContainerUris(MediaAssetStorageContainerSasContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetAssetsRestClient.CreateListContainerSasRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new Uri(e.GetString()), _mediaAssetAssetsClientDiagnostics, Pipeline, "MediaAssetResource.GetStorageContainerUris", "assetContainerSasUrls", null, cancellationToken);
        }

        /// <summary>
        /// Gets the Asset storage encryption keys used to decrypt content created by version 2 of the Media Services API
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/getEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_GetEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StorageEncryptedAssetDecryptionInfo>> GetEncryptionKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.GetEncryptionKey");
            scope.Start();
            try
            {
                var response = await _mediaAssetAssetsRestClient.GetEncryptionKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Asset storage encryption keys used to decrypt content created by version 2 of the Media Services API
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/getEncryptionKey</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_GetEncryptionKey</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StorageEncryptedAssetDecryptionInfo> GetEncryptionKey(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetAssetsClientDiagnostics.CreateScope("MediaAssetResource.GetEncryptionKey");
            scope.Start();
            try
            {
                var response = _mediaAssetAssetsRestClient.GetEncryptionKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Streaming Locators which are associated with this asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/listStreamingLocators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_ListStreamingLocators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaAssetStreamingLocator" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaAssetStreamingLocator> GetStreamingLocatorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetAssetsRestClient.CreateListStreamingLocatorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, MediaAssetStreamingLocator.DeserializeMediaAssetStreamingLocator, _mediaAssetAssetsClientDiagnostics, Pipeline, "MediaAssetResource.GetStreamingLocators", "streamingLocators", null, cancellationToken);
        }

        /// <summary>
        /// Lists Streaming Locators which are associated with this asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/listStreamingLocators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Assets_ListStreamingLocators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaAssetStreamingLocator" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaAssetStreamingLocator> GetStreamingLocators(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaAssetAssetsRestClient.CreateListStreamingLocatorsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, MediaAssetStreamingLocator.DeserializeMediaAssetStreamingLocator, _mediaAssetAssetsClientDiagnostics, Pipeline, "MediaAssetResource.GetStreamingLocators", "streamingLocators", null, cancellationToken);
        }
    }
}
