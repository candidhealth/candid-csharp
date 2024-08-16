using Candid.Net.Core;
using Candid.Net.ThirdPartyPayerRefunds.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayerRefunds;

public partial class ThirdPartyPayerRefundsClient
{
    private RawClient _client;

    internal ThirdPartyPayerRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
