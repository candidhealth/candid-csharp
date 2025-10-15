using Candid.Net.Core;

namespace Candid.Net.Credentialing;

public partial class CredentialingClient
{
    private RawClient _client;

    internal CredentialingClient(RawClient client)
    {
        _client = client;
        V2 = new Candid.Net.Credentialing.V2.V2Client(_client);
    }

    public Candid.Net.Credentialing.V2.V2Client V2 { get; }
}
