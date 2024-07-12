using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerThreshold
{
    [JsonPropertyName("upper_threshold_cents")]
    public int? UpperThresholdCents { get; init; }

    [JsonPropertyName("lower_threshold_cents")]
    public int? LowerThresholdCents { get; init; }

    [JsonPropertyName("disable_paid_incorrectly")]
    public required bool DisablePaidIncorrectly { get; init; }
}
