using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

public partial class CommonClient
{
    private RawClient _client;

    internal CommonClient(RawClient client)
    {
        _client = client;
    }
}
