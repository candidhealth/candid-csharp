using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncountersUniversal;

public partial class EncountersUniversalClient
{
    private RawClient _client;

    internal EncountersUniversalClient(RawClient client)
    {
        _client = client;
    }
}
