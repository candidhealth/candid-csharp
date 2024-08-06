using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerThreshold
{
    [JsonPropertyName("upper_threshold_cents")]
    public int? UpperThresholdCents { get; set; }

    [JsonPropertyName("lower_threshold_cents")]
    public int? LowerThresholdCents { get; set; }

    [JsonPropertyName("disable_paid_incorrectly")]
    public required bool DisablePaidIncorrectly { get; set; }
}
