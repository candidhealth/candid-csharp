using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record ServiceLineAllocationTarget
{
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; init; }

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; init; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; init; }
}
