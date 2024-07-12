using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record Era
{
    [JsonPropertyName("era_id")]
    public required Guid EraId { get; init; }

    [JsonPropertyName("check_number")]
    public required string CheckNumber { get; init; }

    [JsonPropertyName("check_date")]
    public required string CheckDate { get; init; }
}
