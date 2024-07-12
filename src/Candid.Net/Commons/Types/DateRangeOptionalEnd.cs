using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record DateRangeOptionalEnd
{
    [JsonPropertyName("start_date")]
    public required string StartDate { get; init; }

    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }
}
