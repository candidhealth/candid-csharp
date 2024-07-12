using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePaymentCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; init; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; init; } = new List<AllocationCreate>();
}
