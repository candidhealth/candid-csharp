using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ClaimInvoiceItem
{
    [JsonPropertyName("claim_id")]
    public required string ClaimId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
