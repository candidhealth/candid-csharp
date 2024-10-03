using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net.NonInsurancePayerRefunds.V1;

public record NonInsurancePayerRefund
{
    [JsonPropertyName("non_insurance_payer_refund_id")]
    public required string NonInsurancePayerRefundId { get; set; }

    [JsonPropertyName("non_insurance_payer")]
    public required NonInsurancePayer NonInsurancePayer { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
