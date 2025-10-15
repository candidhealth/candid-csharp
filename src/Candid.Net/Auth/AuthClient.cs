using Candid.Net.Auth.Default;
using Candid.Net.Core;

namespace Candid.Net.Auth;

public partial class AuthClient
{
    private RawClient _client;

    internal AuthClient(RawClient client)
    {
        _client = client;
        Default = new DefaultClient(_client);
    }

    public DefaultClient Default { get; }
}
