using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Identifier
{
    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }

    [JsonPropertyName("period")]
    public DateRangeOptionalEnd? Period { get; set; }

    [JsonPropertyName("identifier_code")]
    public required IdentifierCode IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public required object IdentifierValue { get; set; }
}
