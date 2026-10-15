using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EraCommons;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eras;

[Serializable]
public record EraDocument : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("source")]
    public required string Source { get; set; }

    [JsonPropertyName("storage_path")]
    public required string StoragePath { get; set; }

    [JsonPropertyName("status")]
    public required EraDocumentStatus Status { get; set; }

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
