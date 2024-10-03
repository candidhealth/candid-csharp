using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchResult
{
    [JsonPropertyName("threshold")]
    public required ThresholdMatch Threshold { get; set; }

    [JsonPropertyName("rate_id")]
    public required string RateId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
