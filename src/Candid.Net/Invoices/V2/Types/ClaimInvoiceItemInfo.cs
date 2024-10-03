using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record ClaimInvoiceItemInfo
{
    [JsonPropertyName("claim_invoice_item")]
    public ClaimInvoiceItem? ClaimInvoiceItem { get; set; }

    [JsonPropertyName("service_line_invoice_items")]
    public Dictionary<string, ServiceLineInvoiceItem> ServiceLineInvoiceItems { get; set; } =
        new Dictionary<string, ServiceLineInvoiceItem>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
