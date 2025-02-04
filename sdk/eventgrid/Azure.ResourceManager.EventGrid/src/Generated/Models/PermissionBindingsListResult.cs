// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Permission Binding operation. </summary>
    internal partial class PermissionBindingsListResult
    {
        /// <summary> Initializes a new instance of PermissionBindingsListResult. </summary>
        internal PermissionBindingsListResult()
        {
            Value = new ChangeTrackingList<EventGridNamespacePermissionBindingData>();
        }

        /// <summary> Initializes a new instance of PermissionBindingsListResult. </summary>
        /// <param name="value"> A collection of Permission Binding. </param>
        /// <param name="nextLink"> A link for the next page of Permission Binding. </param>
        internal PermissionBindingsListResult(IReadOnlyList<EventGridNamespacePermissionBindingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A collection of Permission Binding. </summary>
        public IReadOnlyList<EventGridNamespacePermissionBindingData> Value { get; }
        /// <summary> A link for the next page of Permission Binding. </summary>
        public string NextLink { get; }
    }
}
