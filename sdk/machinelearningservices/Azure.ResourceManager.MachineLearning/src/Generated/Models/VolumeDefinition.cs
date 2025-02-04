// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The VolumeDefinition. </summary>
    public partial class VolumeDefinition
    {
        /// <summary> Initializes a new instance of VolumeDefinition. </summary>
        public VolumeDefinition()
        {
        }

        /// <summary> Initializes a new instance of VolumeDefinition. </summary>
        /// <param name="definitionType"> Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe. </param>
        /// <param name="readOnly"> Indicate whether to mount volume as readOnly. Default value for this is false. </param>
        /// <param name="source"> Source of the mount. For bind mounts this is the host path. </param>
        /// <param name="target"> Target of the mount. For bind mounts this is the path in the container. </param>
        /// <param name="consistency"> Consistency of the volume. </param>
        /// <param name="bind"> Bind Options of the mount. </param>
        /// <param name="volume"> Volume Options of the mount. </param>
        /// <param name="tmpfs"> tmpfs option of the mount. </param>
        internal VolumeDefinition(VolumeDefinitionType? definitionType, bool? readOnly, string source, string target, string consistency, MountBindOptions bind, VolumeOptions volume, TmpfsOptions tmpfs)
        {
            DefinitionType = definitionType;
            ReadOnly = readOnly;
            Source = source;
            Target = target;
            Consistency = consistency;
            Bind = bind;
            Volume = volume;
            Tmpfs = tmpfs;
        }

        /// <summary> Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe. </summary>
        public VolumeDefinitionType? DefinitionType { get; set; }
        /// <summary> Indicate whether to mount volume as readOnly. Default value for this is false. </summary>
        public bool? ReadOnly { get; set; }
        /// <summary> Source of the mount. For bind mounts this is the host path. </summary>
        public string Source { get; set; }
        /// <summary> Target of the mount. For bind mounts this is the path in the container. </summary>
        public string Target { get; set; }
        /// <summary> Consistency of the volume. </summary>
        public string Consistency { get; set; }
        /// <summary> Bind Options of the mount. </summary>
        public MountBindOptions Bind { get; set; }
        /// <summary> Volume Options of the mount. </summary>
        internal VolumeOptions Volume { get; set; }
        /// <summary> Indicate whether volume is nocopy. </summary>
        public bool? Nocopy
        {
            get => Volume is null ? default : Volume.Nocopy;
            set
            {
                if (Volume is null)
                    Volume = new VolumeOptions();
                Volume.Nocopy = value;
            }
        }

        /// <summary> tmpfs option of the mount. </summary>
        internal TmpfsOptions Tmpfs { get; set; }
        /// <summary> Mention the Tmpfs size. </summary>
        public int? TmpfsSize
        {
            get => Tmpfs is null ? default : Tmpfs.Size;
            set
            {
                if (Tmpfs is null)
                    Tmpfs = new TmpfsOptions();
                Tmpfs.Size = value;
            }
        }
    }
}
