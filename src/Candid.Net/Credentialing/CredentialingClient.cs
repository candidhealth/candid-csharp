using global::Candid.Net.Core;

namespace Candid.Net.Credentialing;

public partial class CredentialingClient : ICredentialingClient
{
    private readonly RawClient _client;

    internal CredentialingClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Credentialing.V2.V2Client(_client);
        V3 = new global::Candid.Net.Credentialing.V3.V3Client(_client);
    }

    public global::Candid.Net.Credentialing.V2.IV2Client V2 { get; }

    public global::Candid.Net.Credentialing.V3.IV3Client V3 { get; }
}
