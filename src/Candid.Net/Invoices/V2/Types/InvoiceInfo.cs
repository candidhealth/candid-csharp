using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

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
}
