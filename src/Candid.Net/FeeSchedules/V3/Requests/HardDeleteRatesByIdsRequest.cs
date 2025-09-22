using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record HardDeleteRatesByIdsRequest
{
    [JsonPropertyName("rate_ids")]
    public IEnumerable<string> RateIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
