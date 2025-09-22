using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record RegionNational
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
