using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefund
{
    [JsonPropertyName("insurance_refund_id")]
    public required Guid InsuranceRefundId { get; init; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; init; } = new List<Allocation>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; init; }
}
