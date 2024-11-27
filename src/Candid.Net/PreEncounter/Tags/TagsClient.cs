using Candid.Net.Core;
using Candid.Net.PreEncounter.Tags.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Tags;

public partial class TagsClient
{
    private RawClient _client;

    internal TagsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
