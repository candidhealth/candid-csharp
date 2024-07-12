using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record ClaimAllocationTarget
{
    [JsonPropertyName("claim_id")]
    public required Guid ClaimId { get; init; }

    [JsonPropertyName("encounter_id")]
    public required Guid EncounterId { get; init; }
}
