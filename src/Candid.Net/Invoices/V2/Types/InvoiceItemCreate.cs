using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceItemCreate
{
    [JsonPropertyName("attribution")]
    public required object Attribution { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
