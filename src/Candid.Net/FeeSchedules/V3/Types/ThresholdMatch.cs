using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Threshold and dollar amount matching for a service line
/// </summary>
[Serializable]
public record ThresholdMatch : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("threshold")]
    public required PayerThreshold Threshold { get; set; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

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
