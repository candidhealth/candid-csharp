using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchModifiers
{
    [JsonPropertyName("value")]
    public HashSet<ProcedureModifier> Value { get; init; } = new HashSet<ProcedureModifier>();

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
