using Candid.Net.Core;
using Candid.Net.EncounterAttachments.V1;

#nullable enable

namespace Candid.Net.EncounterAttachments;

public partial class EncounterAttachmentsClient
{
    private RawClient _client;

    internal EncounterAttachmentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
