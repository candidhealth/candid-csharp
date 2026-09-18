using global::Candid.Net.Core;
using global::Candid.Net.EncounterSummaries.V1;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Views.Dynamic.V1;

[Serializable]
public record ResolveDynamicView
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("filters")]
    public EncounterFilter? Filters { get; set; }

    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// Sort criteria applied in order. Defaults to created_at descending.
    /// </summary>
    [JsonPropertyName("sort")]
    public IEnumerable<SortCriterion>? Sort { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
