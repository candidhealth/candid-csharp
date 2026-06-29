using global::Candid.Net.Core;

namespace Candid.Net.Credentialing;

public partial class CredentialingClient : ICredentialingClient
{
    private readonly RawClient _client;

    internal CredentialingClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Credentialing.V2.V2Client(_client);
    }

    public global::Candid.Net.Credentialing.V2.IV2Client V2 { get; }
}
