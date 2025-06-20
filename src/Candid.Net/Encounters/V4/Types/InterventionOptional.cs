using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record InterventionOptional
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("category")]
    public InterventionCategory? Category { get; set; }

    /// <summary>
    /// "Examples: 'Birth Control LAC', 'Tracking', 'Stress Management', 'Supplement', 'Labs'"
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Required when `type` is `allopathic`.
    /// </summary>
    [JsonPropertyName("medication")]
    public MedicationOptional? Medication { get; set; }

    /// <summary>
    /// Required when `type` is `tests`.
    /// </summary>
    [JsonPropertyName("labs")]
    public IEnumerable<LabOptional>? Labs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
