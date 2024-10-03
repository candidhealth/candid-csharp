using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchTestResult
{
    [JsonPropertyName("dimensions")]
    public required DimensionMatch Dimensions { get; set; }

    [JsonPropertyName("threshold")]
    public required ThresholdMatch Threshold { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
