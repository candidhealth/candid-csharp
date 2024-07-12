using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ClaimInvoiceItem
{
    [JsonPropertyName("claim_id")]
    public required Guid ClaimId { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
