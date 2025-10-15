using Candid.Net.Core;

namespace Candid.Net.BillingNotes;

public partial class BillingNotesClient
{
    private RawClient _client;

    internal BillingNotesClient(RawClient client)
    {
        _client = client;
        V2 = new Candid.Net.BillingNotes.V2.V2Client(_client);
    }

    public Candid.Net.BillingNotes.V2.V2Client V2 { get; }
}
