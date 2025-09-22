using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.EraCommons;
using Candid.Net.X12.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public record ClaimAdjudicationCreate
{
    [JsonPropertyName("claim_status_code")]
    public required ClaimStatusCodeCreate ClaimStatusCode { get; set; }

    [JsonPropertyName("insurance_paid_amount_cents")]
    public int? InsurancePaidAmountCents { get; set; }

    [JsonPropertyName("charge_amount_cents")]
    public int? ChargeAmountCents { get; set; }

    [JsonPropertyName("service_lines")]
    public Dictionary<
        string,
        IEnumerable<ServiceLineAdjudicationCreate>
    > ServiceLines { get; set; } =
        new Dictionary<string, IEnumerable<ServiceLineAdjudicationCreate>>();

    [JsonPropertyName("payer_claim_number")]
    public string? PayerClaimNumber { get; set; }

    [JsonPropertyName("carcs")]
    public IEnumerable<ClaimAdjustmentReasonCode> Carcs { get; set; } =
        new List<ClaimAdjustmentReasonCode>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
