using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record Subscriber
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; init; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; init; }
}
