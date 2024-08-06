using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefund
{
    [JsonPropertyName("patient_refund_id")]
    public required string PatientRefundId { get; set; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    [JsonPropertyName("source_internal_id")]
    public string? SourceInternalId { get; set; }

    [JsonPropertyName("refund_source")]
    public required PatientTransactionSource RefundSource { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; set; }

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }
}
