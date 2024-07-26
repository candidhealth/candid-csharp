using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record SchemaField
{
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonPropertyName("type")]
    public required Primitive Type { get; init; }
}
