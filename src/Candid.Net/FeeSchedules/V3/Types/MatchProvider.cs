using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchProvider
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
