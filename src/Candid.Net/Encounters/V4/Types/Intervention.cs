using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record Intervention
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required InterventionCategory Category { get; set; }

    /// <summary>
    /// "Examples: 'Birth Control LAC', 'Tracking', 'Stress Management', 'Supplement', 'Labs'"
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Required when `type` is `allopathic`.
    /// </summary>
    [JsonPropertyName("medication")]
    public Medication? Medication { get; set; }

    /// <summary>
    /// Required when `type` is `tests`.
    /// </summary>
    [JsonPropertyName("labs")]
    public IEnumerable<Lab>? Labs { get; set; }
}
