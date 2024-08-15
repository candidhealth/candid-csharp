using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments.V1;

public record UpdateThirdPartyPayerPaymentRequest
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public object? PaymentNote { get; set; }

    [JsonPropertyName("invoice_id")]
    public object? InvoiceId { get; set; }
}
