using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Notes;

public partial class NotesClient
{
    private RawClient _client;

    internal NotesClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Notes.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Notes.V1.V1Client V1 { get; }
}
