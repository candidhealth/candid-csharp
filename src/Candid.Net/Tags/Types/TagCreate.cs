using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record TagCreate
{
    [JsonPropertyName("tag_id")]
    public required string TagId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("color")]
    public required TagColorEnum Color { get; set; }
}
