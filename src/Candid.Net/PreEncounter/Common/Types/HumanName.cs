using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record HumanName
{
    [JsonPropertyName("family")]
    public required string Family { get; set; }

    [JsonPropertyName("given")]
    public IEnumerable<string> Given { get; set; } = new List<string>();

    [JsonPropertyName("use")]
    public required NameUse Use { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }
}
