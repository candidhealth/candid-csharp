using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public class V2Client
{
    private RawClient _client;

    public V2Client(RawClient client)
    {
        _client = client;
    }
}
