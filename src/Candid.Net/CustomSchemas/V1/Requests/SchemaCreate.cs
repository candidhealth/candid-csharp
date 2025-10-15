using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

[Serializable]
public record SchemaCreate
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<SchemaField> Fields { get; set; } = new List<SchemaField>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
