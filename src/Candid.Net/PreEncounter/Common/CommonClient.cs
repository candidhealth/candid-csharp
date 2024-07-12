using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public class CommonClient
{
    private RawClient _client;

    public CommonClient(RawClient client)
    {
        _client = client;
    }
}
