using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record ImportInvoice
{
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; init; }

    /// <summary>
    /// The InvoiceItem rollup which contains all claim and service line invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public required InvoiceItemInfo Items { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    /// <summary>
    /// Id of the customer in the source system
    /// </summary>
    [JsonPropertyName("external_customer_identifier")]
    public required string ExternalCustomerIdentifier { get; init; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>
    /// Id of the invoice being imported in the source system
    /// </summary>
    [JsonPropertyName("external_identifier")]
    public required string ExternalIdentifier { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; init; }

    [JsonPropertyName("due_date")]
    public required DateOnly DueDate { get; init; }

    /// <summary>
    /// Total monetary amount (in cents) of all Invoice Items
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; init; }
}
