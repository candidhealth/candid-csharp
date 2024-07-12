using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record Tag
{
    [JsonPropertyName("creator_id")]
    public required string CreatorId { get; init; }

    [JsonPropertyName("tag_id")]
    public required string TagId { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("color")]
    public required TagColorEnum Color { get; init; }
}
