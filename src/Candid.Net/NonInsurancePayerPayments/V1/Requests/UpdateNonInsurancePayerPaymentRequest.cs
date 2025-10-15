using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;

namespace Candid.Net.NonInsurancePayerPayments.V1;

[Serializable]
public record UpdateNonInsurancePayerPaymentRequest
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public NoteUpdate? PaymentNote { get; set; }

    [JsonPropertyName("invoice_id")]
    public InvoiceUpdate? InvoiceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
