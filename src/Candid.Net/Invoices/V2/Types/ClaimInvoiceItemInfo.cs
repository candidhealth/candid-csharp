using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ClaimInvoiceItemInfo
{
    [JsonPropertyName("claim_invoice_item")]
    public ClaimInvoiceItem? ClaimInvoiceItem { get; init; }

    [JsonPropertyName("service_line_invoice_items")]
    public Dictionary<string, ServiceLineInvoiceItem> ServiceLineInvoiceItems { get; init; } =
        new Dictionary<string, ServiceLineInvoiceItem>();
}
