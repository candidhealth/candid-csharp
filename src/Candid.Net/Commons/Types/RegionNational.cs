using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record RegionNational
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
