using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments;

public partial class EncounterAttachmentsClient
{
    private RawClient _client;

    internal EncounterAttachmentsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.EncounterAttachments.V1.V1Client(_client);
    }

    public global::Candid.Net.EncounterAttachments.V1.V1Client V1 { get; }
}
