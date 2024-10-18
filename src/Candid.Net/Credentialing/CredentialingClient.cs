using Candid.Net.Core;
using Candid.Net.Credentialing.V2;

#nullable enable

namespace Candid.Net.Credentialing;

public partial class CredentialingClient
{
    private RawClient _client;

    internal CredentialingClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
