using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record NewRate
{
    [JsonPropertyName("dimensions")]
    public required Dimensions Dimensions { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; set; } = new List<RateEntry>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
