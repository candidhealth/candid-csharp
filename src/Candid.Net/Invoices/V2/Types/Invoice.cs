using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record Invoice
{
    /// <summary>
    /// Total monetary amount (in cents) of all Invoice Items
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; set; }

    /// <summary>
    /// Contains all relevant information from the third-party service this invoice was created in
    /// </summary>
    [JsonPropertyName("invoice_destination_metadata")]
    public required InvoiceDestinationMetadata InvoiceDestinationMetadata { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("due_date")]
    public required DateOnly DueDate { get; set; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; set; }

    /// <summary>
    /// Link to the admin view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    /// <summary>
    /// The InvoiceItem rollup which contains all claim and service line invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public required InvoiceItemInfo Items { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
