using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeQuestion
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("responses")]
    public IEnumerable<IntakeResponseAndFollowUps>? Responses { get; set; }
}
