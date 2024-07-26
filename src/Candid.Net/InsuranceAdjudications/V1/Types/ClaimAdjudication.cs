using System.Text.Json.Serialization;
using Candid.Net.InsuranceAdjudications.V1;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record ClaimAdjudication
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; init; }

    [JsonPropertyName("insurance_allowed_amount_cents")]
    public int? InsuranceAllowedAmountCents { get; init; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; init; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; init; }

    [JsonPropertyName("service_lines")]
    public Dictionary<string, IEnumerable<ServiceLineAdjudication>> ServiceLines { get; init; } =
        new Dictionary<string, IEnumerable<ServiceLineAdjudication>>();

    [JsonPropertyName("payer_claim_number")]
    public string? PayerClaimNumber { get; init; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; init; } =
        new List<ClaimAdjustmentReasonCode>();
}
