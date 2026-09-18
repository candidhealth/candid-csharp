using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

/// <summary>
/// Filter on a text field using either a match operator (equals, contains, starts_with, ends_with) with
/// optional negation, or a lexicographic range (between, not_between) for fixed-width codes like CPT.
/// Use values with the match modes, and min/max with the range modes.
/// </summary>
[Serializable]
public record RangeableStringFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Defaults to equals
    /// </summary>
    [JsonPropertyName("mode")]
    public RangeableStringMatchMode? Mode { get; set; }

    [JsonPropertyName("values")]
    public IEnumerable<string>? Values { get; set; }

    [JsonPropertyName("min")]
    public string? Min { get; set; }

    [JsonPropertyName("max")]
    public string? Max { get; set; }

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
