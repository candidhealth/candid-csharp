using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record IdentifierUpdate
{
    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }

    [JsonPropertyName("identifier_code")]
    public IdentifierCode? IdentifierCode { get; set; }

    [JsonPropertyName("identifier_value")]
    public object? IdentifierValue { get; set; }

    [JsonPropertyName("period")]
    public object? Period { get; set; }
}
