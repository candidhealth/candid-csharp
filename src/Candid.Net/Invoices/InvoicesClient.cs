using Candid.Net.Core;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices;

public partial class InvoicesClient
{
    private RawClient _client;

    internal InvoicesClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
