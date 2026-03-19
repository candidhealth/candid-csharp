using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Tags;

public partial class TagsClient : ITagsClient
{
    private readonly RawClient _client;

    internal TagsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Tags.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Tags.V1.IV1Client V1 { get; }
}
