using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public record PatientRefundCreate
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; init; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; init; } = new List<AllocationCreate>();

    [JsonPropertyName("invoice")]
    public string? Invoice { get; init; }

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; init; }
}
