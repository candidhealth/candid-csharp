using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// A comprehensive rate including the current rate value and all values for historic time ranges. The time ranges specified by each RateEntry are disjoint.  A rate must always have at least one entry.
/// </summary>
[Serializable]
public record Rate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
