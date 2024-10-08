using Candid.Net.BillingNotes.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.BillingNotes;

public partial class BillingNotesClient
{
    private RawClient _client;

    internal BillingNotesClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
