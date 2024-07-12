using System.Text.Json.Serialization;
using Candid.Net.ServiceLines.V2;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record ServiceLineAdjudication
{
    [JsonPropertyName("service_line_adjudication_id")]
    public required Guid ServiceLineAdjudicationId { get; init; }

    /// <summary>
    /// Will be treated as a denial if present
    /// </summary>
    [JsonPropertyName("denial_reason")]
    public DenialReasonContent? DenialReason { get; init; }

    [JsonPropertyName("insurance_allowed_amount_cents")]
    public int? InsuranceAllowedAmountCents { get; init; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; init; }

    [JsonPropertyName("deductible_amount_cents")]
    public int? DeductibleAmountCents { get; init; }

    [JsonPropertyName("coinsurance_amount_cents")]
    public int? CoinsuranceAmountCents { get; init; }

    [JsonPropertyName("copay_amount_cents")]
    public int? CopayAmountCents { get; init; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; init; } =
        new List<ClaimAdjustmentReasonCode>();

    [JsonPropertyName("rarcs")]
    public IEnumerable<RemittanceAdviceRemarkCode> Rarcs { get; init; } =
        new List<RemittanceAdviceRemarkCode>();
}
