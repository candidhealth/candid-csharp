using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net;

public record Claim
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; init; }

    [JsonPropertyName("status")]
    public required ClaimStatus Status { get; init; }

    [JsonPropertyName("clearinghouse")]
    public string? Clearinghouse { get; init; }

    [JsonPropertyName("clearinghouse_claim_id")]
    public string? ClearinghouseClaimId { get; init; }

    [JsonPropertyName("payer_claim_id")]
    public string? PayerClaimId { get; init; }

    [JsonPropertyName("clia_number")]
    public string? CliaNumber { get; init; }

    [JsonPropertyName("service_lines")]
    public IEnumerable<ServiceLine> ServiceLines { get; init; } = new List<ServiceLine>();

    [JsonPropertyName("eras")]
    public IEnumerable<Era> Eras { get; init; } = new List<Era>();
}
