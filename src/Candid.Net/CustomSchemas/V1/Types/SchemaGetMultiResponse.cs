using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaGetMultiResponse
{
    [JsonPropertyName("schemas")]
    public IEnumerable<Schema> Schemas { get; set; } = new List<Schema>();
}
