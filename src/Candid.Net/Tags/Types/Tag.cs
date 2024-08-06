using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Tag
{
    [JsonPropertyName("creator_id")]
    public required string CreatorId { get; set; }
}
