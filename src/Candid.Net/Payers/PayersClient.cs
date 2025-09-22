using Candid.Net.Core;
using Candid.Net.Payers.V3;
using Candid.Net.Payers.V4;

#nullable enable

namespace Candid.Net.Payers;

public partial class PayersClient
{
    private RawClient _client;

    internal PayersClient(RawClient client)
    {
        _client = client;
        V3 = new V3Client(_client);
        V4 = new V4Client(_client);
    }

    public V3Client V3 { get; }

    public V4Client V4 { get; }
}
