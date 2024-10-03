using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public record InsuranceRefundCreate
{
    [JsonPropertyName("payer_identifier")]
    public required object PayerIdentifier { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
