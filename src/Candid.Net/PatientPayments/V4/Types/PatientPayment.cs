using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPayment
{
    [JsonPropertyName("patient_payment_id")]
    public required string PatientPaymentId { get; init; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    [JsonPropertyName("source_internal_id")]
    public string? SourceInternalId { get; init; }

    [JsonPropertyName("payment_source")]
    public required PatientTransactionSource PaymentSource { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; init; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; init; } = new List<Allocation>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; init; }
}
