using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();
}
