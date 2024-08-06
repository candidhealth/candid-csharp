using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record StandaloneDiagnosisCreate
{
    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }
}
