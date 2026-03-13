using Candid.Net.Core;

namespace Candid.Net.Encounters;

public partial class EncountersClient : IEncountersClient
{
    private readonly RawClient _client;

    internal EncountersClient(RawClient client)
    {
        _client = client;
        V4 = new global::Candid.Net.Encounters.V4.V4Client(_client);
    }

    public global::Candid.Net.Encounters.V4.IV4Client V4 { get; }
}
