using System.Text.Json.Serialization;
using global::Candid.Net.Core;
using global::Candid.Net.Financials;

namespace Candid.Net.PatientPayments.V4;

[Serializable]
public record PatientPaymentUpdate
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public NoteUpdate? PaymentNote { get; set; }

    [JsonPropertyName("invoice")]
    public InvoiceUpdate? Invoice { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
