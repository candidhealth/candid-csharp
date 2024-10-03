using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaCreate
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<SchemaField> Fields { get; set; } = new List<SchemaField>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
