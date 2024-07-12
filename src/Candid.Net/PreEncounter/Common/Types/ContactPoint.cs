using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ContactPoint
{
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonPropertyName("use")]
    public required ContactPointUse Use { get; init; }

    [JsonPropertyName("period")]
    public Period? Period { get; init; }
}
