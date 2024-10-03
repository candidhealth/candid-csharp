using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayerRefunds.V1;

public record NonInsurancePayerRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public object? RefundNote { get; set; }

    [JsonPropertyName("refund_reason")]
    public object? RefundReason { get; set; }

    [JsonPropertyName("invoice_id")]
    public object? InvoiceId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
