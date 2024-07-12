using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record IntakeResponseAndFollowUps
{
    [JsonPropertyName("response")]
    public string? Response { get; init; }

    [JsonPropertyName("follow_ups")]
    public IEnumerable<IntakeFollowUp>? FollowUps { get; init; }
}
