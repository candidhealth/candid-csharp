using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record ServiceLineAllocationTarget
{
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("encounter_id")]
    public required string EncounterId { get; set; }
}
