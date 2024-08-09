using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record ImportInvoiceUpdateRequest
{
    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    [JsonPropertyName("status")]
    public InvoiceStatus? Status { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("due_date")]
    public DateOnly? DueDate { get; set; }

    /// <summary>
    /// None here represents there is no update to the invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public InvoiceItemInfoUpdate? Items { get; set; }
}
