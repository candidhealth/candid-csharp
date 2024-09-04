using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments.V1;

public record ThirdPartyPayerPaymentCreate
{
    [JsonPropertyName("third_party_payer_id")]
    public required string ThirdPartyPayerId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("payment_timestamp")]
    public DateTime? PaymentTimestamp { get; set; }

    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; set; }

    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<AllocationCreate> Allocations { get; set; } = new List<AllocationCreate>();

    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; set; }
}