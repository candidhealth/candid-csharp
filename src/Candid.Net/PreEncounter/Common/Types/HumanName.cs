using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record HumanName
{
    [JsonPropertyName("family")]
    public required string Family { get; init; }

    [JsonPropertyName("given")]
    public IEnumerable<string> Given { get; init; } = new List<string>();

    [JsonPropertyName("use")]
    public required NameUse Use { get; init; }

    [JsonPropertyName("period")]
    public Period? Period { get; init; }
}
