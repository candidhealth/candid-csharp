using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Diagnosis
{
    [JsonPropertyName("diagnosis_id")]
    public required string DiagnosisId { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }
}
