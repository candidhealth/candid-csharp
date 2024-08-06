using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Identifier
{
    [JsonPropertyName("identifier_id")]
    public required string IdentifierId { get; set; }
}
