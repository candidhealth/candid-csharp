using global::Candid.Net.Core;

namespace Candid.Net.Events;

public partial class EventsClient : IEventsClient
{
    private readonly RawClient _client;

    internal EventsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Events.V1.V1Client(_client);
    }

    public global::Candid.Net.Events.V1.IV1Client V1 { get; }
}
