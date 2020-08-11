// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties supplied for Subnet. </summary>
    public partial class Subnet
    {
        /// <summary> Initializes a new instance of Subnet. </summary>
        public Subnet()
        {
        }

        /// <summary> Initializes a new instance of Subnet. </summary>
        /// <param name="id"> Resource ID of Virtual Network Subnet. </param>
        internal Subnet(string id)
        {
            Id = id;
        }

        /// <summary> Resource ID of Virtual Network Subnet. </summary>
        public string Id { get; set; }
    }
}
