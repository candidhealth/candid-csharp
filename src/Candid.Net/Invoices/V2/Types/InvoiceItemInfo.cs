using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceItemInfo
{
    [JsonPropertyName("claim_invoice_items")]
    public Dictionary<string, ClaimInvoiceItemInfo> ClaimInvoiceItems { get; init; } =
        new Dictionary<string, ClaimInvoiceItemInfo>();

    [JsonPropertyName("unattributed_items")]
    public IEnumerable<UnattributedInvoiceItem> UnattributedItems { get; init; } =
        new List<UnattributedInvoiceItem>();
}
