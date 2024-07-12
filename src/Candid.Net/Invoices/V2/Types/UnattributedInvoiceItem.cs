using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record UnattributedInvoiceItem
{
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
