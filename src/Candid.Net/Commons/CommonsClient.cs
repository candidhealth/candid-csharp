using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class CommonsClient
{
    private RawClient _client;

    public CommonsClient(RawClient client)
    {
        _client = client;
    }
}
