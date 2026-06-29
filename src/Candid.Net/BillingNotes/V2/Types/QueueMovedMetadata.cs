using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.BillingNotes.V2;

[Serializable]
public record QueueMovedMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from_queue_id")]
    public required string FromQueueId { get; set; }

    [JsonPropertyName("from_queue_name")]
    public required string FromQueueName { get; set; }

    [JsonPropertyName("to_queue_id")]
    public required string ToQueueId { get; set; }

    [JsonPropertyName("to_queue_name")]
    public required string ToQueueName { get; set; }

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
