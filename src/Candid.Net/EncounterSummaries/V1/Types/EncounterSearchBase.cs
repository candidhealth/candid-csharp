using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

/// <summary>
/// Shared request fields for encounter search endpoints.
/// </summary>
[Serializable]
public record EncounterSearchBase : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("filters")]
    public EncounterFilter? Filters { get; set; }

    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// Sort criteria applied in order. Defaults to created_at descending.
    /// </summary>
    [JsonPropertyName("sort")]
    public IEnumerable<SortCriterion>? Sort { get; set; }

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
