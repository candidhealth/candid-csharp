using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.ThirdPartyPayerRefunds.V1;

public record ThirdPartyPayerRefundCreate
{
    [JsonPropertyName("third_party_payer_id")]
    public required string ThirdPartyPayerId { get; set; }

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }

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
}
