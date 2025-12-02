using Candid.Net.Core;

namespace Candid.Net.Events;

public partial class EventsClient
{
    private RawClient _client;

    internal EventsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Events.V1.V1Client(_client);
    }

    public global::Candid.Net.Events.V1.V1Client V1 { get; }
}
