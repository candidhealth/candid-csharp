using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPaymentUpdate
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public object? PaymentNote { get; set; }

    [JsonPropertyName("invoice")]
    public object? Invoice { get; set; }
}
