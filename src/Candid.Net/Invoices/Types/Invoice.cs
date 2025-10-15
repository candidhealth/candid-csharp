using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Invoices;

[Serializable]
public record Invoice : IJsonOnDeserialized
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
