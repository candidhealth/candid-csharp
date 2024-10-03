using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchModifiers
{
    [JsonPropertyName("value")]
    public HashSet<ProcedureModifier> Value { get; set; } = new HashSet<ProcedureModifier>();

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
