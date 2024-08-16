using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }
}
