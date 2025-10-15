using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the payload for a Medicare Advantage recommendation.
/// </summary>
[Serializable]
public record MedicareAdvantageRecommendationPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ma_benefit")]
    public object? MaBenefit { get; set; }

    [JsonPropertyName("payer_id")]
    public string? PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public string? PayerName { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

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
