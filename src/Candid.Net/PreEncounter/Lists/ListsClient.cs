using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists;

public partial class ListsClient : IListsClient
{
    private readonly RawClient _client;

    internal ListsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Lists.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Lists.V1.IV1Client V1 { get; }
}
