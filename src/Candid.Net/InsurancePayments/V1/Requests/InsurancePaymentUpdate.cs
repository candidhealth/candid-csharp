using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentUpdate
{
    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public object? PaymentNote { get; set; }
}
