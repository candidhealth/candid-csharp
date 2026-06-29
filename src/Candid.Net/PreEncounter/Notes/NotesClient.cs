using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Notes;

public partial class NotesClient : INotesClient
{
    private readonly RawClient _client;

    internal NotesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Notes.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Notes.V1.IV1Client V1 { get; }
}
