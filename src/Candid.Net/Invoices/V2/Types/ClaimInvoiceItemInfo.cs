using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ClaimInvoiceItemInfo
{
    [JsonPropertyName("claim_invoice_item")]
    public ClaimInvoiceItem? ClaimInvoiceItem { get; set; }

    [JsonPropertyName("service_line_invoice_items")]
    public Dictionary<string, ServiceLineInvoiceItem> ServiceLineInvoiceItems { get; set; } =
        new Dictionary<string, ServiceLineInvoiceItem>();
}
