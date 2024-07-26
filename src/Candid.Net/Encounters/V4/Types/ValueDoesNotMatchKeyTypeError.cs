using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ValueDoesNotMatchKeyTypeError
{
    [JsonPropertyName("schema_id")]
    public required string SchemaId { get; init; }

    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonPropertyName("expected_value_type")]
    public required Primitive ExpectedValueType { get; init; }

    [JsonPropertyName("value")]
    public required object Value { get; init; }
}
