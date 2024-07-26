using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record IdentifierUpdate
{
    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; init; }

    [JsonPropertyName("identifier_code")]
    public IdentifierCode? IdentifierCode { get; init; }

    [JsonPropertyName("identifier_value")]
    public object? IdentifierValue { get; init; }

    [JsonPropertyName("period")]
    public object? Period { get; init; }
}
