using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceInfo
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("invoice")]
    public required Invoice Invoice { get; set; }

    [JsonPropertyName("invoice_type")]
    public required InvoiceDestination InvoiceType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
