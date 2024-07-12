using Candid.Net.Auth.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Auth;

public class AuthClient
{
    private RawClient _client;

    public AuthClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
