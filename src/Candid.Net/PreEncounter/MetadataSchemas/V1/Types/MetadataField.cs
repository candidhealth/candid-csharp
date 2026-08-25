using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.MetadataSchemas.V1;

/// <summary>
/// A single typed field within a custom metadata schema.
/// </summary>
[Serializable]
public record MetadataField : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("type")]
    public required MetadataFieldType Type { get; set; }

    /// <summary>
    /// The allowed values for the field. Required when type is ENUM, otherwise omitted.
    /// </summary>
    [JsonPropertyName("enum_values")]
    public IEnumerable<string>? EnumValues { get; set; }

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
