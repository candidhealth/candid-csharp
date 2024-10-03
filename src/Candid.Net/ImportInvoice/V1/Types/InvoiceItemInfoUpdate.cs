using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record InvoiceItemInfoUpdate
{
    /// <summary>
    /// The only supported update operations for invoice items is to either overwrite the entire list of invoice items
    /// or to append new invoice items
    /// </summary>
    [JsonPropertyName("update_type")]
    public required InvoiceItemUpdateType UpdateType { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItemCreate> Items { get; set; } = new List<InvoiceItemCreate>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
