using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net;

public record Claim
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("status")]
    public required ClaimStatus Status { get; set; }

    [JsonPropertyName("clearinghouse")]
    public string? Clearinghouse { get; set; }

    [JsonPropertyName("clearinghouse_claim_id")]
    public string? ClearinghouseClaimId { get; set; }

    [JsonPropertyName("payer_claim_id")]
    public string? PayerClaimId { get; set; }

    [JsonPropertyName("clia_number")]
    public string? CliaNumber { get; set; }

    [JsonPropertyName("service_lines")]
    public IEnumerable<ServiceLine> ServiceLines { get; set; } = new List<ServiceLine>();

    [JsonPropertyName("eras")]
    public IEnumerable<Era> Eras { get; set; } = new List<Era>();
}
