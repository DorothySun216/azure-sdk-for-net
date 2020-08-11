// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Plan for the managed application. </summary>
    public partial class PlanPatchable
    {
        /// <summary> Initializes a new instance of PlanPatchable. </summary>
        public PlanPatchable()
        {
        }

        /// <summary> Initializes a new instance of PlanPatchable. </summary>
        /// <param name="name"> The plan name. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> The product code. </param>
        /// <param name="promotionCode"> The promotion code. </param>
        /// <param name="version"> The plan&apos;s version. </param>
        internal PlanPatchable(string name, string publisher, string product, string promotionCode, string version)
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            Version = version;
        }

        /// <summary> The plan name. </summary>
        public string Name { get; set; }
        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> The product code. </summary>
        public string Product { get; set; }
        /// <summary> The promotion code. </summary>
        public string PromotionCode { get; set; }
        /// <summary> The plan&apos;s version. </summary>
        public string Version { get; set; }
    }
}
