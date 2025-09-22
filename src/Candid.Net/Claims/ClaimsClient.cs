using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Claims;

public partial class ClaimsClient
{
    private RawClient _client;

    internal ClaimsClient(RawClient client)
    {
        _client = client;
    }
}
