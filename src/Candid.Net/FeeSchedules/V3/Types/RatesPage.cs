using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record RatesPage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rates")]
    public IEnumerable<Rate> Rates { get; set; } = new List<Rate>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

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
