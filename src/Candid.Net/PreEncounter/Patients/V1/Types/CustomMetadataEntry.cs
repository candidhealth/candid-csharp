using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// A set of custom key/value pairs validated against a single MetadataSchema.
/// </summary>
[Serializable]
public record CustomMetadataEntry : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("metadata_schema_id")]
    public required string MetadataSchemaId { get; set; }

    /// <summary>
    /// The custom values. Each key must be a field defined on the referenced MetadataSchema and each value must match that field's declared type.
    /// </summary>
    [JsonPropertyName("key_value_pairs")]
    public Dictionary<string, object?> KeyValuePairs { get; set; } =
        new Dictionary<string, object?>();

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
