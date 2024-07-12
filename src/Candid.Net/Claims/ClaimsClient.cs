using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class ClaimsClient
{
    private RawClient _client;

    public ClaimsClient(RawClient client)
    {
        _client = client;
    }
}
