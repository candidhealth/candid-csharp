using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record RateEntry
{
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    [JsonPropertyName("rate_cents")]
    public required int RateCents { get; set; }

    [JsonPropertyName("is_deactivated")]
    public required bool IsDeactivated { get; set; }
}
