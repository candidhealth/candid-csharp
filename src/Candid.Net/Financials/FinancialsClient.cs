using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class FinancialsClient
{
    private RawClient _client;

    public FinancialsClient(RawClient client)
    {
        _client = client;
    }
}
