using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record Invoice
{
    /// <summary>
    /// Total monetary amount (in cents) of all Invoice Items
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; init; }

    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// Contains all relevant information from the third-party service this invoice was created in
    /// </summary>
    [JsonPropertyName("invoice_destination_metadata")]
    public required InvoiceDestinationMetadata InvoiceDestinationMetadata { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    [JsonPropertyName("due_date")]
    public required DateOnly DueDate { get; init; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>
    /// Link to the admin view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; init; }

    /// <summary>
    /// The InvoiceItem rollup which contains all claim and service line invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public required InvoiceItemInfo Items { get; init; }
}
