using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record CreateImportInvoiceRequest
{
    [JsonPropertyName("external_payment_account_config_id")]
    public required string ExternalPaymentAccountConfigId { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    /// <summary>
    /// Id of the customer in the source system
    /// </summary>
    [JsonPropertyName("external_customer_identifier")]
    public required string ExternalCustomerIdentifier { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// If given as None, days_until_due in the payment config will be used to create a default date
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItemCreate> Items { get; set; } = new List<InvoiceItemCreate>();

    [JsonPropertyName("status")]
    public required Invoices.V2.InvoiceStatus Status { get; set; }

    /// <summary>
    /// Id of the invoice being imported in the source system. Warning - This field CANNOT be updated.
    /// </summary>
    [JsonPropertyName("external_identifier")]
    public required string ExternalIdentifier { get; set; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
