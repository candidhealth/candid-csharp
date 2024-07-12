using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record RateEntry
{
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; init; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; init; }

    [JsonPropertyName("is_deactivated")]
    public required bool IsDeactivated { get; init; }
}
