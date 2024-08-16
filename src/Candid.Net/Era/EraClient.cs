using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public partial class EraClient
{
    private RawClient _client;

    internal EraClient(RawClient client)
    {
        _client = client;
    }
}
