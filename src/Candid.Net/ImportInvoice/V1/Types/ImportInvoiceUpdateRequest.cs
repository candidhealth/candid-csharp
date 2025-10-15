using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ImportInvoice.V1;

[Serializable]
public record ImportInvoiceUpdateRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Link to the patient view of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("customer_invoice_url")]
    public string? CustomerInvoiceUrl { get; set; }

    [JsonPropertyName("status")]
    public Candid.Net.Invoices.V2.InvoiceStatus? Status { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    [JsonPropertyName("due_date")]
    public DateOnly? DueDate { get; set; }

    /// <summary>
    /// None here represents there is no update to the invoice items
    /// </summary>
    [JsonPropertyName("items")]
    public InvoiceItemInfoUpdate? Items { get; set; }

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
