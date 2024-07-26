using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public record KeyWithNameAlreadyExistsError
{
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonPropertyName("value_type")]
    public required Primitive ValueType { get; init; }
}
