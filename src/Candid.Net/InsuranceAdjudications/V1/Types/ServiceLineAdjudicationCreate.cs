using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.ServiceLines.V2;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record ServiceLineAdjudicationCreate
{
    /// <summary>
    /// Will be treated as a denial if present
    /// </summary>
    [JsonPropertyName("denial_reason")]
    public DenialReasonContent? DenialReason { get; set; }

    [JsonPropertyName("insurance_allowed_amount_cents")]
    public int? InsuranceAllowedAmountCents { get; set; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; set; }

    [JsonPropertyName("deductible_amount_cents")]
    public int? DeductibleAmountCents { get; set; }

    [JsonPropertyName("coinsurance_amount_cents")]
    public int? CoinsuranceAmountCents { get; set; }

    [JsonPropertyName("copay_amount_cents")]
    public int? CopayAmountCents { get; set; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; set; } =
        new List<ClaimAdjustmentReasonCode>();

    [JsonPropertyName("rarcs")]
    public IEnumerable<RemittanceAdviceRemarkCode> Rarcs { get; set; } =
        new List<RemittanceAdviceRemarkCode>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
