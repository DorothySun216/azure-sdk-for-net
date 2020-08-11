// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The managed artifact. </summary>
    internal partial class ManagedArtifact
    {
        /// <summary> Initializes a new instance of ManagedArtifact. </summary>
        /// <param name="id"> The managed artifact id. </param>
        internal ManagedArtifact(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> The managed artifact id. </summary>
        public string Id { get; }
    }
}
