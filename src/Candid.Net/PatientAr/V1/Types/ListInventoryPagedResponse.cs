using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[Serializable]
public record ListInventoryPagedResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of inventory records matching the filters
    /// </summary>
    [JsonPropertyName("records")]
    public IEnumerable<InventoryRecord> Records { get; set; } = new List<InventoryRecord>();

    /// <summary>
    /// Token for the next page of results, if available
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

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
