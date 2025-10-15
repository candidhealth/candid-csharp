using Candid.Net.Core;

namespace Candid.Net.ImportInvoice;

public partial class ImportInvoiceClient
{
    private RawClient _client;

    internal ImportInvoiceClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.ImportInvoice.V1.V1Client(_client);
    }

    public Candid.Net.ImportInvoice.V1.V1Client V1 { get; }
}
