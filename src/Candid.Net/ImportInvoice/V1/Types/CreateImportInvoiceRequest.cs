using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record CreateImportInvoiceRequest
{
    [JsonPropertyName("external_payment_account_config_id")]
    public required Guid ExternalPaymentAccountConfigId { get; init; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; init; }

    /// <summary>
    /// Id of the customer in the source system
    /// </summary>
    [JsonPropertyName("external_customer_identifier")]
    public required string ExternalCustomerIdentifier { get; init; }

    [JsonPropertyName("note")]
    public string? Note { get; init; }

    /// <summary>
    /// If given as None, days_until_due in the payment config will be used to create a default date
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateOnly? DueDate { get; init; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItemCreate> Items { get; init; } = new List<InvoiceItemCreate>();

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>
    /// Id of the invoice being imported in the source system. Warning - This field CANNOT be updated.
    /// </summary>
    [JsonPropertyName("external_identifier")]
    public required string ExternalIdentifier { get; init; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; init; }
}
