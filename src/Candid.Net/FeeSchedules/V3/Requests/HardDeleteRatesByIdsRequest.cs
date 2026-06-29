using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

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
