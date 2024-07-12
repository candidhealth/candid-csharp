using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Intervention
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("category")]
    public required InterventionCategory Category { get; init; }

    /// <summary>
    /// "Examples: 'Birth Control LAC', 'Tracking', 'Stress Management', 'Supplement', 'Labs'"
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Required when `type` is `allopathic`.
    /// </summary>
    [JsonPropertyName("medication")]
    public Medication? Medication { get; init; }

    /// <summary>
    /// Required when `type` is `tests`.
    /// </summary>
    [JsonPropertyName("labs")]
    public IEnumerable<Lab>? Labs { get; init; }
}
