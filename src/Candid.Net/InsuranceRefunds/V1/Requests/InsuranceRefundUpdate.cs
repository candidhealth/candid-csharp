using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public object? RefundNote { get; set; }

    [JsonPropertyName("refund_reason")]
    public object? RefundReason { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
