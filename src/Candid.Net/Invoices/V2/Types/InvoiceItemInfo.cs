using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

[Serializable]
public record InvoiceItemInfo : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("claim_invoice_items")]
    public Dictionary<string, ClaimInvoiceItemInfo> ClaimInvoiceItems { get; set; } =
        new Dictionary<string, ClaimInvoiceItemInfo>();

    [JsonPropertyName("unattributed_items")]
    public IEnumerable<UnattributedInvoiceItem> UnattributedItems { get; set; } =
        new List<UnattributedInvoiceItem>();

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
