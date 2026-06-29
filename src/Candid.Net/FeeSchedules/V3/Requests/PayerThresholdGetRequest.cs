using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record PayerThresholdGetRequest
{
    [JsonIgnore]
    public IEnumerable<string> PayerUuids { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
