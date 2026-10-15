using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// A rate that matched a dimension point, with the entry in effect on the point's date of service.
/// </summary>
[Serializable]
public record MatchedRate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The entry from `entries` in effect on the point's date of service. Its `rate_cents` is the per-unit amount.
    /// </summary>
    [JsonPropertyName("matched_entry")]
    public required RateEntry MatchedEntry { get; set; }

    /// <summary>
    /// The matched entry's rate_cents multiplied by the point's quantity, rounded to the nearest cent (half to even).
    /// </summary>
    [JsonPropertyName("total_cents")]
    public required int TotalCents { get; set; }

    [JsonPropertyName("rate_id")]
    public required string RateId { get; set; }

    /// <summary>
    /// The dimension values that distinguish this rate from others.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public required Dimensions Dimensions { get; set; }

    /// <summary>
    /// The version of this rate in the system.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateOnly UpdatedAt { get; set; }

    [JsonPropertyName("updated_by")]
    public required string UpdatedBy { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; set; } = new List<RateEntry>();

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
