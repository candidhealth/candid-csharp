using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefund
{
    [JsonPropertyName("patient_refund_id")]
    public required string PatientRefundId { get; init; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    [JsonPropertyName("source_internal_id")]
    public string? SourceInternalId { get; init; }

    [JsonPropertyName("refund_source")]
    public required PatientTransactionSource RefundSource { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; init; } = new List<Allocation>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; init; }

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; init; }
}
