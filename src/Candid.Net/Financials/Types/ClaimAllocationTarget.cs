using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record ClaimAllocationTarget
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }
}
