using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeFollowUp
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("response")]
    public string? Response { get; set; }
}
