using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;

namespace Candid.Net.NonInsurancePayerRefunds.V1;

[Serializable]
public record NonInsurancePayerRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public NoteUpdate? RefundNote { get; set; }

    [JsonPropertyName("refund_reason")]
    public RefundReasonUpdate? RefundReason { get; set; }

    [JsonPropertyName("invoice_id")]
    public InvoiceUpdate? InvoiceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
