using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists;

public partial class ListsClient
{
    private RawClient _client;

    internal ListsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Lists.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Lists.V1.V1Client V1 { get; }
}
