using Candid.Net.Core;
using Candid.Net.ImportInvoice.V1;

#nullable enable

namespace Candid.Net.ImportInvoice;

public class ImportInvoiceClient
{
    private RawClient _client;

    public ImportInvoiceClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
