using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaInstance
{
    /// <summary>
    /// The schema to which the content must adhere.
    /// </summary>
    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; set; }

    /// <summary>
    /// A set of key-value pairs that adhere to the naming and type convention of the schema. Not all keys in the schema must be included, but attaching any key that does not exist in the schema or attaching a key with the incorrect value type will result in errors.
    /// </summary>
    [JsonPropertyName("content")]
    public Dictionary<string, object?> Content { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
