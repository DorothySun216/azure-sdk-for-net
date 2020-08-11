// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleConditionType");
            writer.WriteStringValue(RuleConditionType.ToString());
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRuleCondition DeserializeFirewallPolicyRuleCondition(JsonElement element)
        {
            if (element.TryGetProperty("ruleConditionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ApplicationRuleCondition": return ApplicationRuleCondition.DeserializeApplicationRuleCondition(element);
                    case "NatRuleCondition": return NatRuleCondition.DeserializeNatRuleCondition(element);
                    case "NetworkRuleCondition": return NetworkRuleCondition.DeserializeNetworkRuleCondition(element);
                }
            }
            string name = default;
            string description = default;
            FirewallPolicyRuleConditionType ruleConditionType = default;
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
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleConditionType"))
                {
                    ruleConditionType = new FirewallPolicyRuleConditionType(property.Value.GetString());
                    continue;
                }
            }
            return new FirewallPolicyRuleCondition(name, description, ruleConditionType);
        }
    }
}
