using System.Text.Json.Serialization;
using Candid.Net.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
