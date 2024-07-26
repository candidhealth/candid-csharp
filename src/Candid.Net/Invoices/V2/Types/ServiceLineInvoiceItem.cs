using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ServiceLineInvoiceItem
{
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; init; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
