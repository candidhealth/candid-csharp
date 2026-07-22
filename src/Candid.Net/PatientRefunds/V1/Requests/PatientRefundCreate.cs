using global::Candid.Net.Core;
using global::Candid.Net.Financials;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PatientRefunds.V1;

[Serializable]
public record PatientRefundCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; set; }

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }

    /// <summary>
    /// Optional restrictions constraining which claims this refund's credit can be
    /// auto-allocated to (e.g. billing provider NPI). Restriction (type, value) pairs must be
    /// unique. When omitted, the refund is unrestricted. Refunds created from an existing
    /// payment inherit that payment's restrictions instead.
    /// </summary>
    [JsonPropertyName("allocation_restrictions")]
    public IEnumerable<AllocationRestrictionCreate>? AllocationRestrictions { get; set; }

    /// <summary>
    /// If true, the refund will be rejected if it would cause any account to be overdrafted. Defaults to false.
    /// </summary>
    [JsonPropertyName("raise_on_overdraft")]
    public bool? RaiseOnOverdraft { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
