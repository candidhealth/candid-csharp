using System.Text.Json.Serialization;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record DimensionsPage
{
    [JsonPropertyName("dimensions")]
    public IEnumerable<OptionalDimensions> Dimensions { get; set; } =
        new List<OptionalDimensions>();

    [JsonPropertyName("prev_page_token")]
    public string? PrevPageToken { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
