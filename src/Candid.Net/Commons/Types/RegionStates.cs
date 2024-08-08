using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record RegionStates
{
    [JsonPropertyName("states")]
    public IEnumerable<State> States { get; set; } = new List<State>();
}
