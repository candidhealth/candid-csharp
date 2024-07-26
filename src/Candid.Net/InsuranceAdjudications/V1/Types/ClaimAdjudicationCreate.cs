using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.InsuranceAdjudications.V1;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record ClaimAdjudicationCreate
{
    [JsonPropertyName("claim_status_code")]
    public required ClaimStatusCodeCreate ClaimStatusCode { get; init; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; init; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; init; }

    [JsonPropertyName("service_lines")]
    public Dictionary<
        string,
        IEnumerable<ServiceLineAdjudicationCreate>
    > ServiceLines { get; init; } =
        new Dictionary<string, IEnumerable<ServiceLineAdjudicationCreate>>();

    [JsonPropertyName("payer_claim_number")]
    public string? PayerClaimNumber { get; init; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; init; } =
        new List<ClaimAdjustmentReasonCode>();
}
