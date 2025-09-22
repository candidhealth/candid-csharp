using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record RegionStates
{
    [JsonPropertyName("states")]
    public IEnumerable<State> States { get; set; } = new List<State>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
