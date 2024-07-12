using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchFacilityTypeCode
{
    [JsonPropertyName("value")]
    public FacilityTypeCode? Value { get; init; }

    [JsonPropertyName("match")]
    public required bool Match { get; init; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; init; }
}
