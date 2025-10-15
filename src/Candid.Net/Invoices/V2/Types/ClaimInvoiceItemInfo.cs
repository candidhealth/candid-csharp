using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

[Serializable]
public record ClaimInvoiceItemInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("claim_invoice_item")]
    public ClaimInvoiceItem? ClaimInvoiceItem { get; set; }

    [JsonPropertyName("service_line_invoice_items")]
    public Dictionary<string, ServiceLineInvoiceItem> ServiceLineInvoiceItems { get; set; } =
        new Dictionary<string, ServiceLineInvoiceItem>();

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
