using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.Invoices.V2;

namespace Candid.Net.ImportInvoice.V1;

[Serializable]
public record ImportInvoice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The InvoiceItem rollup which contains all claim and service line invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public required InvoiceItemInfo Items { get; set; }

    [JsonPropertyName("patient_external_id")]
    public required string PatientExternalId { get; set; }

    /// <summary>
    /// Id of the customer in the source system
    /// </summary>
    [JsonPropertyName("external_customer_identifier")]
    public required string ExternalCustomerIdentifier { get; set; }

    [JsonPropertyName("status")]
    public required global::Candid.Net.Invoices.V2.InvoiceStatus Status { get; set; }

    /// <summary>
    /// Id of the invoice being imported in the source system
    /// </summary>
    [JsonPropertyName("external_identifier")]
    public required string ExternalIdentifier { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    [JsonPropertyName("due_date")]
    public required DateOnly DueDate { get; set; }

    /// <summary>
    /// Total monetary amount (in cents) of all Invoice Items
    /// </summary>
    [JsonPropertyName("amount_cents")]
    public required int AmountCents { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
