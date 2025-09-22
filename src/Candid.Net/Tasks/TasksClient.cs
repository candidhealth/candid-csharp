using Candid.Net.Core;
using Candid.Net.Tasks.Commons;
using Candid.Net.Tasks.V3;

#nullable enable

namespace Candid.Net.Tasks;

public partial class TasksClient
{
    private RawClient _client;

    internal TasksClient(RawClient client)
    {
        _client = client;
        V3 = new V3Client(_client);
        Commons = new CommonsClient(_client);
    }

    public V3Client V3 { get; }

    public CommonsClient Commons { get; }
}
