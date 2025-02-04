// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The alias type. </summary>
    public partial class ResourceTypeAlias
    {
        /// <summary> Initializes a new instance of ResourceTypeAlias. </summary>
        internal ResourceTypeAlias()
        {
            Paths = new ChangeTrackingList<ResourceTypeAliasPath>();
        }

        /// <summary> Initializes a new instance of ResourceTypeAlias. </summary>
        /// <param name="name"> The alias name. </param>
        /// <param name="paths"> The paths for an alias. </param>
        /// <param name="aliasType"> The type of the alias. </param>
        /// <param name="defaultPath"> The default path for an alias. </param>
        /// <param name="defaultPattern"> The default pattern for an alias. </param>
        /// <param name="defaultMetadata"> The default alias path metadata. Applies to the default path and to any alias path that doesn't have metadata. </param>
        internal ResourceTypeAlias(string name, IReadOnlyList<ResourceTypeAliasPath> paths, ResourceTypeAliasType? aliasType, string defaultPath, ResourceTypeAliasPattern defaultPattern, ResourceTypeAliasPathMetadata defaultMetadata)
        {
            Name = name;
            Paths = paths;
            AliasType = aliasType;
            DefaultPath = defaultPath;
            DefaultPattern = defaultPattern;
            DefaultMetadata = defaultMetadata;
        }

        /// <summary> The alias name. </summary>
        public string Name { get; }
        /// <summary> The paths for an alias. </summary>
        public IReadOnlyList<ResourceTypeAliasPath> Paths { get; }
        /// <summary> The type of the alias. </summary>
        public ResourceTypeAliasType? AliasType { get; }
        /// <summary> The default path for an alias. </summary>
        public string DefaultPath { get; }
        /// <summary> The default pattern for an alias. </summary>
        public ResourceTypeAliasPattern DefaultPattern { get; }
        /// <summary> The default alias path metadata. Applies to the default path and to any alias path that doesn't have metadata. </summary>
        public ResourceTypeAliasPathMetadata DefaultMetadata { get; }
    }
}
