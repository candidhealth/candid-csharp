using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class IndividualClient
{
    private RawClient _client;

    public IndividualClient(RawClient client)
    {
        _client = client;
    }
}
