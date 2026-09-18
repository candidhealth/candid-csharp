using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

/// <summary>
/// Filter on a datetime field by specifying an inclusive range. Either bound may be omitted for an open-ended range.
/// </summary>
[Serializable]
public record DatetimeRangeFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Defaults to between
    /// </summary>
    [JsonPropertyName("mode")]
    public DatetimeRangeMatchMode? Mode { get; set; }

    [JsonPropertyName("min")]
    public DateTime? Min { get; set; }

    [JsonPropertyName("max")]
    public DateTime? Max { get; set; }

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
