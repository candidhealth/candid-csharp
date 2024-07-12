using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceInfo
{
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    [JsonPropertyName("invoice")]
    public required Invoice Invoice { get; init; }

    [JsonPropertyName("invoice_type")]
    public required InvoiceDestination InvoiceType { get; init; }
}
