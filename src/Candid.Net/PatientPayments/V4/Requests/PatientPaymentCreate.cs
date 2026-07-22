using global::Candid.Net.Core;
using global::Candid.Net.Financials;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PatientPayments.V4;

[Serializable]
public record PatientPaymentCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; set; }

    [JsonPropertyName("payment_method_detail")]
    public PaymentMethodDetailCreate? PaymentMethodDetail { get; set; }

    [JsonPropertyName("payment_source")]
    public PatientPaymentCreateSource? PaymentSource { get; set; }

    [JsonPropertyName("source_internal_id")]
    public string? SourceInternalId { get; set; }

    /// <summary>
    /// Optional restrictions constraining which claims this payment's credit can be
    /// auto-allocated to (e.g. billing provider NPI). Restriction (type, value) pairs must be
    /// unique. When omitted, the payment is unrestricted.
    /// </summary>
    [JsonPropertyName("allocation_restrictions")]
    public IEnumerable<AllocationRestrictionCreate>? AllocationRestrictions { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
