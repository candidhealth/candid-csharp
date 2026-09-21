using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.WorkQueues.V2;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

/// <summary>
/// Filter on work queue category by matching against a set of allowed categories, with optional
/// negation.
/// </summary>
[Serializable]
public record WorkQueueCategorySetFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Defaults to IN
    /// </summary>
    [JsonPropertyName("mode")]
    public SetMatchMode? Mode { get; set; }

    [JsonPropertyName("values")]
    public IEnumerable<WorkQueueCategory> Values { get; set; } = new List<WorkQueueCategory>();

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
