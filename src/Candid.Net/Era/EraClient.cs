using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class EraClient
{
    private RawClient _client;

    public EraClient(RawClient client)
    {
        _client = client;
    }
}
