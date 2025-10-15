using Candid.Net.Core;

namespace Candid.Net.ImportInvoice;

public partial class ImportInvoiceClient
{
    private RawClient _client;

    internal ImportInvoiceClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.ImportInvoice.V1.V1Client(_client);
    }

    public global::Candid.Net.ImportInvoice.V1.V1Client V1 { get; }
}
