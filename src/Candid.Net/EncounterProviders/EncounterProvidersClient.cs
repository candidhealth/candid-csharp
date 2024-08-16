using Candid.Net.Core;
using Candid.Net.EncounterProviders.V2;

#nullable enable

namespace Candid.Net.EncounterProviders;

public partial class EncounterProvidersClient
{
    private RawClient _client;

    internal EncounterProvidersClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
