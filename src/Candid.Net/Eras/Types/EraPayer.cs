using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record EraPayer : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    /// <summary>
    /// Centers for Medicare and Medicaid Services PlanID. Used when reporting Health Plan ID (HPID) or Other Entity Identifier (OEID).
    /// </summary>
    [JsonPropertyName("payer_identifier")]
    public string? PayerIdentifier { get; set; }

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
