// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityInformation
    {
        internal static ConnectivityInformation DeserializeConnectivityInformation(JsonElement element)
        {
            IReadOnlyList<ConnectivityHop> hops = default;
            ConnectionStatus? connectionStatus = default;
            int? avgLatencyInMs = default;
            int? minLatencyInMs = default;
            int? maxLatencyInMs = default;
            int? probesSent = default;
            int? probesFailed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityHop> array = new List<ConnectivityHop>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ConnectivityHop.DeserializeConnectivityHop(item));
                        }
                    }
                    hops = array;
                    continue;
                }
                if (property.NameEquals("connectionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new ConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesSent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesSent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesFailed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesFailed = property.Value.GetInt32();
                    continue;
                }
            }
            return new ConnectivityInformation(hops, connectionStatus, avgLatencyInMs, minLatencyInMs, maxLatencyInMs, probesSent, probesFailed);
        }
    }
}
