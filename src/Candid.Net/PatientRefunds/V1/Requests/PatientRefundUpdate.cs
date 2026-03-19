using System.Text.Json.Serialization;
using global::Candid.Net.Core;
using global::Candid.Net.Financials;

namespace Candid.Net.PatientRefunds.V1;

[Serializable]
public record PatientRefundUpdate
{
    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public NoteUpdate? RefundNote { get; set; }

    [JsonPropertyName("invoice")]
    public InvoiceUpdate? Invoice { get; set; }

    [JsonPropertyName("refund_reason")]
    public RefundReasonUpdate? RefundReason { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
