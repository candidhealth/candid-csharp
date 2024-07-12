using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeFollowUp
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("response")]
    public string? Response { get; init; }
}
