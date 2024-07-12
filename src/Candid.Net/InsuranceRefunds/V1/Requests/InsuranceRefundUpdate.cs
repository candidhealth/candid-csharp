using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public object? RefundNote { get; init; }

    [JsonPropertyName("refund_reason")]
    public object? RefundReason { get; init; }
}
