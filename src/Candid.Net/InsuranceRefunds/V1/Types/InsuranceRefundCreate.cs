using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; init; } = new List<AllocationCreate>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; init; }
}
