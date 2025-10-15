using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record Intervention : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("category")]
    public required InterventionCategory Category { get; set; }

    /// <summary>
    /// "Examples: 'Birth Control LAC', 'Tracking', 'Stress Management', 'Supplement', 'Labs'"
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Required when `type` is `allopathic`.
    /// </summary>
    [JsonPropertyName("medication")]
    public Medication? Medication { get; set; }

    /// <summary>
    /// Required when `type` is `tests`.
    /// </summary>
    [JsonPropertyName("labs")]
    public IEnumerable<Lab>? Labs { get; set; }

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
