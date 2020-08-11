// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinMetadata
    {
        internal static DeviceTwinMetadata DeserializeDeviceTwinMetadata(JsonElement element)
        {
            Optional<string> lastUpdated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdated"))
                {
                    lastUpdated = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceTwinMetadata(lastUpdated.Value);
        }
    }
}
