using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Tag
{
    [JsonPropertyName("creator_id")]
    public required string CreatorId { get; set; }

    [JsonPropertyName("tag_id")]
    public required string TagId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("color")]
    public required TagColorEnum Color { get; set; }
}
