using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Tags;

public partial class TagsClient
{
    private RawClient _client;

    internal TagsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Tags.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Tags.V1.V1Client V1 { get; }
}
