using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ContactPoint
{
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("use")]
    public required ContactPointUse Use { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }
}
