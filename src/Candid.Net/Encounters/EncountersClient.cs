using Candid.Net.Core;

namespace Candid.Net.Encounters;

public partial class EncountersClient
{
    private RawClient _client;

    internal EncountersClient(RawClient client)
    {
        _client = client;
        V4 = new Candid.Net.Encounters.V4.V4Client(_client);
    }

    public Candid.Net.Encounters.V4.V4Client V4 { get; }
}
