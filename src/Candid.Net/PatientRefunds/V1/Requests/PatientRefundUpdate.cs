using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public object? RefundNote { get; init; }

    [JsonPropertyName("invoice")]
    public object? Invoice { get; init; }

    [JsonPropertyName("refund_reason")]
    public object? RefundReason { get; init; }
}
