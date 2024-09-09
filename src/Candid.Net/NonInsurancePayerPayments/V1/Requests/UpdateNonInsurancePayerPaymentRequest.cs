using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.NonInsurancePayerPayments.V1;

public record UpdateNonInsurancePayerPaymentRequest
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public object? PaymentNote { get; set; }

    [JsonPropertyName("invoice_id")]
    public object? InvoiceId { get; set; }
}
