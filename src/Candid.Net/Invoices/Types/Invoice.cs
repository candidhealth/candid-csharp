using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record Invoice
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; init; }

    [JsonPropertyName("organzation_id")]
    public required string OrganzationId { get; init; }

    [JsonPropertyName("source_id")]
    public required string SourceId { get; init; }

    [JsonPropertyName("source_customer_id")]
    public required string SourceCustomerId { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonPropertyName("due_date")]
    public required string DueDate { get; init; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; init; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItem> Items { get; init; } = new List<InvoiceItem>();
}
