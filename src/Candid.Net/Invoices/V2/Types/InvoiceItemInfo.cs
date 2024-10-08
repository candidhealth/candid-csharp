using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceItemInfo
{
    [JsonPropertyName("claim_invoice_items")]
    public Dictionary<string, ClaimInvoiceItemInfo> ClaimInvoiceItems { get; set; } =
        new Dictionary<string, ClaimInvoiceItemInfo>();

    [JsonPropertyName("unattributed_items")]
    public IEnumerable<UnattributedInvoiceItem> UnattributedItems { get; set; } =
        new List<UnattributedInvoiceItem>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
