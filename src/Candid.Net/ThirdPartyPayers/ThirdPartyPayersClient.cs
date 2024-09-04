using Candid.Net.Core;
using Candid.Net.ThirdPartyPayers.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayers;

public partial class ThirdPartyPayersClient
{
    private RawClient _client;

    internal ThirdPartyPayersClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}