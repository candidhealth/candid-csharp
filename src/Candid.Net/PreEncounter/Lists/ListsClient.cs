using Candid.Net.Core;
using Candid.Net.PreEncounter.Lists.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Lists;

public partial class ListsClient
{
    private RawClient _client;

    internal ListsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
