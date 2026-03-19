using global::Candid.Net.Core;

namespace Candid.Net.EncounterProviders;

public partial class EncounterProvidersClient : IEncounterProvidersClient
{
    private readonly RawClient _client;

    internal EncounterProvidersClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.EncounterProviders.V2.V2Client(_client);
    }

    public global::Candid.Net.EncounterProviders.V2.IV2Client V2 { get; }
}
