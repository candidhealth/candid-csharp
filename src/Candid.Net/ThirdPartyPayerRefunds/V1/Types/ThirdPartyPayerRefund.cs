using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ThirdPartyPayers.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayerRefunds.V1;

public record ThirdPartyPayerRefund
{
    [JsonPropertyName("third_party_payer_refund_id")]
    public required string ThirdPartyPayerRefundId { get; set; }

    [JsonPropertyName("third_party_payer")]
    public required ThirdPartyPayer ThirdPartyPayer { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("refund_timestamp")]
    public DateTime? RefundTimestamp { get; set; }

    [JsonPropertyName("refund_note")]
    public string? RefundNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("refund_reason")]
    public RefundReason? RefundReason { get; set; }

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }
}
