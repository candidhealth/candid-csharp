using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record IdentifierBase
{
    [JsonPropertyName("period")]
    public DateRangeOptionalEnd? Period { get; init; }

    [JsonPropertyName("identifier_code")]
    public required IdentifierCode IdentifierCode { get; init; }

    [JsonPropertyName("identifier_value")]
    public required object IdentifierValue { get; init; }
}
