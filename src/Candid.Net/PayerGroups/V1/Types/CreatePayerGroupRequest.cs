using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PayerGroups.V1;

[Serializable]
public record CreatePayerGroupRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// An optional set of payer plan group IDs to move into the new group in the same
    /// transaction. Omitting this field or passing an empty set behaves exactly like
    /// the existing create (an empty group is created).
    /// </summary>
    [JsonPropertyName("payer_plan_group_ids")]
    public HashSet<string>? PayerPlanGroupIds { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
