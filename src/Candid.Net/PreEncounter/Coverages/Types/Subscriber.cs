using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Subscriber
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    [JsonPropertyName("dateOfBirth")]
    public required DateOnly DateOfBirth { get; init; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }
}
