using global::Candid.Net.Core;
using global::Candid.Net.Financials;
using global::System.Text.Json.Serialization;

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
