using System.Text.Json.Serialization;
using Candid.Net.PatientPayments.V3;

#nullable enable

namespace Candid.Net.PatientPayments.V3;

public record PatientPayment
{
    [JsonPropertyName("patient_payment_id")]
    public required string PatientPaymentId { get; init; }

    [JsonPropertyName("organization_id")]
    public required Guid OrganizationId { get; init; }

    [JsonPropertyName("source_internal_id")]
    public required string SourceInternalId { get; init; }

    [JsonPropertyName("source")]
    public required PatientPaymentSource Source { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; init; }

    [JsonPropertyName("status")]
    public PatientPaymentStatus? Status { get; init; }

    [JsonPropertyName("payment_name")]
    public string? PaymentName { get; init; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    [JsonPropertyName("patient_external_id")]
    public string? PatientExternalId { get; init; }

    [JsonPropertyName("encounter_external_id")]
    public string? EncounterExternalId { get; init; }

    [JsonPropertyName("service_line_id")]
    public Guid? ServiceLineId { get; init; }
}
