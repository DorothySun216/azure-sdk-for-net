// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class AzurePowerShellScript : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("identity");
            writer.WriteObjectValue(Identity);
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (SystemData != null)
            {
                writer.WritePropertyName("systemData");
                writer.WriteObjectValue(SystemData);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ContainerSettings != null)
            {
                writer.WritePropertyName("containerSettings");
                writer.WriteObjectValue(ContainerSettings);
            }
            if (StorageAccountSettings != null)
            {
                writer.WritePropertyName("storageAccountSettings");
                writer.WriteObjectValue(StorageAccountSettings);
            }
            if (CleanupPreference != null)
            {
                writer.WritePropertyName("cleanupPreference");
                writer.WriteStringValue(CleanupPreference.Value.ToString());
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteObjectValue(Status);
            }
            if (Outputs != null)
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartObject();
                foreach (var item in Outputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (PrimaryScriptUri != null)
            {
                writer.WritePropertyName("primaryScriptUri");
                writer.WriteStringValue(PrimaryScriptUri);
            }
            if (SupportingScriptUris != null)
            {
                writer.WritePropertyName("supportingScriptUris");
                writer.WriteStartArray();
                foreach (var item in SupportingScriptUris)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ScriptContent != null)
            {
                writer.WritePropertyName("scriptContent");
                writer.WriteStringValue(ScriptContent);
            }
            if (Arguments != null)
            {
                writer.WritePropertyName("arguments");
                writer.WriteStringValue(Arguments);
            }
            if (EnvironmentVariables != null)
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ForceUpdateTag != null)
            {
                writer.WritePropertyName("forceUpdateTag");
                writer.WriteStringValue(ForceUpdateTag);
            }
            writer.WritePropertyName("retentionInterval");
            writer.WriteStringValue(RetentionInterval, "P");
            if (Timeout != null)
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WritePropertyName("azPowerShellVersion");
            writer.WriteStringValue(AzPowerShellVersion);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzurePowerShellScript DeserializeAzurePowerShellScript(JsonElement element)
        {
            ManagedServiceIdentity identity = default;
            string location = default;
            IDictionary<string, string> tags = default;
            ScriptType kind = default;
            SystemData systemData = default;
            string id = default;
            string name = default;
            string type = default;
            ContainerConfiguration containerSettings = default;
            StorageAccountConfiguration storageAccountSettings = default;
            CleanupOptions? cleanupPreference = default;
            ScriptProvisioningState? provisioningState = default;
            ScriptStatus status = default;
            IDictionary<string, object> outputs = default;
            string primaryScriptUri = default;
            IList<string> supportingScriptUris = default;
            string scriptContent = default;
            string arguments = default;
            IList<EnvironmentVariable> environmentVariables = default;
            string forceUpdateTag = default;
            TimeSpan retentionInterval = default;
            TimeSpan? timeout = default;
            string azPowerShellVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    identity = ManagedServiceIdentity.DeserializeManagedServiceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
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
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("containerSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerSettings = ContainerConfiguration.DeserializeContainerConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSettings = StorageAccountConfiguration.DeserializeStorageAccountConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cleanupPreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cleanupPreference = new CleanupOptions(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ScriptProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ScriptStatus.DeserializeScriptStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            outputs = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("primaryScriptUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryScriptUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportingScriptUris"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            supportingScriptUris = array;
                            continue;
                        }
                        if (property0.NameEquals("scriptContent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scriptContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arguments"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            arguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EnvironmentVariable> array = new List<EnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(EnvironmentVariable.DeserializeEnvironmentVariable(item));
                                }
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("forceUpdateTag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionInterval"))
                        {
                            retentionInterval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("timeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("azPowerShellVersion"))
                        {
                            azPowerShellVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzurePowerShellScript(id, name, type, identity, location, tags, kind, systemData, containerSettings, storageAccountSettings, cleanupPreference, provisioningState, status, outputs, primaryScriptUri, supportingScriptUris, scriptContent, arguments, environmentVariables, forceUpdateTag, retentionInterval, timeout, azPowerShellVersion);
        }
    }
}
