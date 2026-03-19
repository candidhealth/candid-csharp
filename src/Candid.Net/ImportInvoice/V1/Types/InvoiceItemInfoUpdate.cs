using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.Invoices.V2;

namespace Candid.Net.ImportInvoice.V1;

[Serializable]
public record InvoiceItemInfoUpdate : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The only supported update operations for invoice items is to either overwrite the entire list of invoice items
    /// or to append new invoice items
    /// </summary>
    [JsonPropertyName("update_type")]
    public required InvoiceItemUpdateType UpdateType { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<InvoiceItemCreate> Items { get; set; } = new List<InvoiceItemCreate>();

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
