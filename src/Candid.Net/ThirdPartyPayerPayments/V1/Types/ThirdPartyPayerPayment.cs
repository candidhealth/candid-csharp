using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ThirdPartyPayers.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments.V1;

public record ThirdPartyPayerPayment
{
    [JsonPropertyName("third_party_payer_payment_id")]
    public required string ThirdPartyPayerPaymentId { get; set; }

    [JsonPropertyName("third_party_payer")]
    public required ThirdPartyPayer ThirdPartyPayer { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<Allocation> Allocations { get; set; } = new List<Allocation>();

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }
}
