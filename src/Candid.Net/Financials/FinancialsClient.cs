using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public partial class FinancialsClient
{
    private RawClient _client;

    internal FinancialsClient(RawClient client)
    {
        _client = client;
    }
}
