using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
