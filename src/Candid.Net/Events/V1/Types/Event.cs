using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Events.V1;

[Serializable]
public record Event : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("timestamp")]
    public required DateTime Timestamp { get; set; }

    [JsonPropertyName("event_type")]
    public required string EventType { get; set; }

    [JsonPropertyName("schema_version")]
    public required string SchemaVersion { get; set; }

    [JsonPropertyName("payload")]
    public required object Payload { get; set; }

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
