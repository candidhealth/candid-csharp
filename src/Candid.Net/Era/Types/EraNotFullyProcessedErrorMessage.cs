using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EraNotFullyProcessedErrorMessage
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
