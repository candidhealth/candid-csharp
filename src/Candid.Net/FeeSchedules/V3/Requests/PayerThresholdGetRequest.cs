using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdGetRequest
{
    public IEnumerable<string> PayerUuids { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
