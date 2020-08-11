// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static class AccessPolicyUpdateKindExtensions
    {
        public static string ToSerialString(this AccessPolicyUpdateKind value) => value switch
        {
            AccessPolicyUpdateKind.Add => "add",
            AccessPolicyUpdateKind.Replace => "replace",
            AccessPolicyUpdateKind.Remove => "remove",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessPolicyUpdateKind value.")
        };

        public static AccessPolicyUpdateKind ToAccessPolicyUpdateKind(this string value)
        {
            if (string.Equals(value, "add", StringComparison.InvariantCultureIgnoreCase)) return AccessPolicyUpdateKind.Add;
            if (string.Equals(value, "replace", StringComparison.InvariantCultureIgnoreCase)) return AccessPolicyUpdateKind.Replace;
            if (string.Equals(value, "remove", StringComparison.InvariantCultureIgnoreCase)) return AccessPolicyUpdateKind.Remove;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccessPolicyUpdateKind value.");
        }
    }
}
