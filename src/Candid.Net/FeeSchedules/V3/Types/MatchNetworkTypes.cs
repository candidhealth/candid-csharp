using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchNetworkTypes
{
    [JsonPropertyName("value")]
    public HashSet<NetworkType> Value { get; set; } = new HashSet<NetworkType>();

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
