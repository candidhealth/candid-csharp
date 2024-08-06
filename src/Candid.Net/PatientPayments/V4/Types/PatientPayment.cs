using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public record PatientPayment
{
    [JsonPropertyName("patient_payment_id")]
    public required string PatientPaymentId { get; set; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    [JsonPropertyName("source_internal_id")]
    public string? SourceInternalId { get; set; }

    [JsonPropertyName("payment_source")]
    public required PatientTransactionSource PaymentSource { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; set; }
}
