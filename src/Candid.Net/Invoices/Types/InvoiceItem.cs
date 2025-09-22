using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices;

public record InvoiceItem
{
    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
