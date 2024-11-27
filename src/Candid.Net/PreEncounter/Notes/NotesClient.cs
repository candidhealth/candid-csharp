using Candid.Net.Core;
using Candid.Net.PreEncounter.Notes.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Notes;

public partial class NotesClient
{
    private RawClient _client;

    internal NotesClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
