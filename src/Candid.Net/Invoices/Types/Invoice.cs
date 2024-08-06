using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record Invoice
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("organzation_id")]
    public required string OrganzationId { get; set; }

    [JsonPropertyName("source_id")]
    public required string SourceId { get; set; }

    [JsonPropertyName("source_customer_id")]
    public required string SourceCustomerId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("due_date")]
    public required string DueDate { get; set; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
}
