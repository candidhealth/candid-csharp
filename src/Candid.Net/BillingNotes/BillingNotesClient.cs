using global::Candid.Net.Core;

namespace Candid.Net.BillingNotes;

public partial class BillingNotesClient : IBillingNotesClient
{
    private readonly RawClient _client;

    internal BillingNotesClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.BillingNotes.V2.V2Client(_client);
    }

    public global::Candid.Net.BillingNotes.V2.IV2Client V2 { get; }
}
