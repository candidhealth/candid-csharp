using Candid.Net.Core;
using Candid.Net.Superbills.V1;

#nullable enable

namespace Candid.Net.Superbills;

public partial class SuperbillsClient
{
    private RawClient _client;

    internal SuperbillsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
