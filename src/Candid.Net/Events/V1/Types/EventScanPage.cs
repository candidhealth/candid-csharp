using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Events.V1;

[Serializable]
public record EventScanPage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<Event> Items { get; set; } = new List<Event>();

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
