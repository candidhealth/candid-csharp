using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaWithNameAlreadyExistsError
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("id")]
    public required string Id { get; init; }
}
