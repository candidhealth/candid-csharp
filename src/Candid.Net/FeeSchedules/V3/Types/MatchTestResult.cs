using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record MatchTestResult
{
    [JsonPropertyName("dimensions")]
    public required DimensionMatch Dimensions { get; set; }

    [JsonPropertyName("threshold")]
    public required ThresholdMatch Threshold { get; set; }
}
