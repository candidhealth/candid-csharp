using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefund
{
    [JsonPropertyName("insurance_refund_id")]
    public required string InsuranceRefundId { get; set; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; set; }

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
}
