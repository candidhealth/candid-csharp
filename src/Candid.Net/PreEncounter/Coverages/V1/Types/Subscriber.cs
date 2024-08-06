using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record Subscriber
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; set; }

    [JsonPropertyName("gender")]
    public required Gender Gender { get; set; }
}
