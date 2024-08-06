using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Period
{
    [JsonPropertyName("start")]
    public DateOnly? Start { get; set; }

    [JsonPropertyName("end")]
    public DateOnly? End { get; set; }
}
