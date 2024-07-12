using Candid.Net.Core;
using Candid.Net.ExpectedNetworkStatus.V1;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus;

public class ExpectedNetworkStatusClient
{
    private RawClient _client;

    public ExpectedNetworkStatusClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
        V2 = new V2Client(_client);
    }

    public V1Client V1 { get; }

    public V2Client V2 { get; }
}
