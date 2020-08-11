// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ServiceTagsListResult
    {
        internal static ServiceTagsListResult DeserializeServiceTagsListResult(JsonElement element)
        {
            string name = default;
            string id = default;
            string type = default;
            string changeNumber = default;
            string cloud = default;
            IReadOnlyList<ServiceTagInformation> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeNumber"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTagInformation> array = new List<ServiceTagInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ServiceTagInformation.DeserializeServiceTagInformation(item));
                        }
                    }
                    values = array;
                    continue;
                }
            }
            return new ServiceTagsListResult(name, id, type, changeNumber, cloud, values);
        }
    }
}
