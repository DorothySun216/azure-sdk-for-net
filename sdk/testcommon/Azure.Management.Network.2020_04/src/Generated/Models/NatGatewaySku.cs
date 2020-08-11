// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> SKU of nat gateway. </summary>
    public partial class NatGatewaySku
    {
        /// <summary> Initializes a new instance of NatGatewaySku. </summary>
        public NatGatewaySku()
        {
            Name = "Standard";
        }

        /// <summary> Initializes a new instance of NatGatewaySku. </summary>
        /// <param name="name"> Name of Nat Gateway SKU. </param>
        internal NatGatewaySku(string name)
        {
            Name = name;
        }

        /// <summary> Name of Nat Gateway SKU. </summary>
        public string Name { get; set; }
    }
}
