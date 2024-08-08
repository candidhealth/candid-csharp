using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record Schema
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<SchemaField> Fields { get; set; } = new List<SchemaField>();
}
