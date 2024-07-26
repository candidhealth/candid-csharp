using System.Text.Json.Serialization;
using Candid.Net.CustomSchemas.V1;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaGetMultiResponse
{
    [JsonPropertyName("schemas")]
    public IEnumerable<Schema> Schemas { get; init; } = new List<Schema>();
}
