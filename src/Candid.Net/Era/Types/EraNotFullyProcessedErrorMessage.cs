using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EraNotFullyProcessedErrorMessage
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }
}
