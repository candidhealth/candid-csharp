using Candid.Net.Core;

namespace Candid.Net.Payers;

public partial class PayersClient
{
    private RawClient _client;

    internal PayersClient(RawClient client)
    {
        _client = client;
        V3 = new global::Candid.Net.Payers.V3.V3Client(_client);
        V4 = new global::Candid.Net.Payers.V4.V4Client(_client);
    }

    public global::Candid.Net.Payers.V3.V3Client V3 { get; }

    public global::Candid.Net.Payers.V4.V4Client V4 { get; }
}
