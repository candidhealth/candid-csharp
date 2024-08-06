using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record EraBase
{
    [JsonPropertyName("check_number")]
    public required string CheckNumber { get; set; }

    [JsonPropertyName("check_date")]
    public required string CheckDate { get; set; }
}
