using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPaymentCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; init; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; init; } = new List<AllocationCreate>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; init; }
}
