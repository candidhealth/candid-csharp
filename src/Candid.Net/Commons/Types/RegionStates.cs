using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record RegionStates
{
    [JsonPropertyName("states")]
    public IEnumerable<State> States { get; set; } = new List<State>();
}
