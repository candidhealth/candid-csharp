using global::Candid.Net.Core;

namespace Candid.Net.Users;

public partial class UsersClient : IUsersClient
{
    private readonly RawClient _client;

    internal UsersClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Users.V2.V2Client(_client);
    }

    public global::Candid.Net.Users.V2.IV2Client V2 { get; }
}
