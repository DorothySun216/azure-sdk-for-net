// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnSite Resource. </summary>
    internal partial class VpnSiteId
    {
        /// <summary> Initializes a new instance of VpnSiteId. </summary>
        internal VpnSiteId()
        {
        }

        /// <summary> Initializes a new instance of VpnSiteId. </summary>
        /// <param name="vpnSite"> The resource-uri of the vpn-site for which config is to be fetched. </param>
        internal VpnSiteId(string vpnSite)
        {
            VpnSite = vpnSite;
        }

        /// <summary> The resource-uri of the vpn-site for which config is to be fetched. </summary>
        public string VpnSite { get; }
    }
}
