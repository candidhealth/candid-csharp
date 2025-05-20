using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record EmptyObject
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
