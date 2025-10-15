using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

[Serializable]
public record SchemaInstanceOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The schema to which the content must adhere.
    /// </summary>
    [JsonPropertyName("schema_id")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// A set of key-value pairs that adhere to the naming and type convention of the schema. Not all keys in the schema must be included, but attaching any key that does not exist in the schema or attaching a key with the incorrect value type will result in errors.
    /// </summary>
    [JsonPropertyName("content")]
    public Dictionary<string, object?>? Content { get; set; }

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
