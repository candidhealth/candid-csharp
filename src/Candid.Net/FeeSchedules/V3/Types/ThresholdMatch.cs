using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record ThresholdMatch
{
    [JsonPropertyName("threshold")]
    public required PayerThreshold Threshold { get; set; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; set; }

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
