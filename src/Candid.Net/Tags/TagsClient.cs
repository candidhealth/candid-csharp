using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class TagsClient
{
    private RawClient _client;

    public TagsClient(RawClient client)
    {
        _client = client;
    }
}
