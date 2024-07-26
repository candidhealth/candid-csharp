using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record Schema
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("fields")]
    public IEnumerable<SchemaField> Fields { get; init; } = new List<SchemaField>();
}