using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public record InsurancePayment
{
    [JsonPropertyName("insurance_payment_id")]
    public required string InsurancePaymentId { get; init; }

    [JsonPropertyName("payer")]
    public required Payer Payer { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; init; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; init; } = new List<Allocation>();
}
