using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tags;

public partial class TagsClient
{
    private RawClient _client;

    internal TagsClient(RawClient client)
    {
        _client = client;
    }
}
