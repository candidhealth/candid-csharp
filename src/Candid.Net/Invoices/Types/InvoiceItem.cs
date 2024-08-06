using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record InvoiceItem
{
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }
}
