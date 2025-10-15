using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record HardDeleteRatesByIdsRequest
{
    [JsonPropertyName("rate_ids")]
    public IEnumerable<string> RateIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
