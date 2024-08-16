using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public partial class IndividualClient
{
    private RawClient _client;

    internal IndividualClient(RawClient client)
    {
        _client = client;
    }
}
