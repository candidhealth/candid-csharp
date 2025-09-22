using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public partial class CommonsClient
{
    private RawClient _client;

    internal CommonsClient(RawClient client)
    {
        _client = client;
    }
}
