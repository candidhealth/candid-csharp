using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

/// <summary>
/// The result of a pre-service run.
/// </summary>
[Serializable]
public record PreServiceRun : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("run_id")]
    public required string RunId { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// The client's internal ID for the entity that was submitted for pre-service rule processing.
    /// </summary>
    [JsonPropertyName("entity_external_id")]
    public required string EntityExternalId { get; set; }

    /// <summary>
    /// Recommended edits to the submitted entity.
    /// </summary>
    [JsonPropertyName("edits")]
    public Dictionary<string, object?>? Edits { get; set; }

    /// <summary>
    /// Actions recommended by the rules engine.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<object> Actions { get; set; } = new List<object>();

    /// <summary>
    /// Set if the run encountered an unrecoverable error.
    /// </summary>
    [JsonPropertyName("error")]
    public PreServiceError? Error { get; set; }

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
