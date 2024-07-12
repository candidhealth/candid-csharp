using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters;

public class EncountersClient
{
    private RawClient _client;

    public EncountersClient(RawClient client)
    {
        _client = client;
        V4 = new V4Client(_client);
    }

    public V4Client V4 { get; }
}
