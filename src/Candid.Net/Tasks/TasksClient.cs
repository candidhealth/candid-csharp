using Candid.Net.Core;

namespace Candid.Net.Tasks;

public partial class TasksClient
{
    private RawClient _client;

    internal TasksClient(RawClient client)
    {
        _client = client;
        V3 = new global::Candid.Net.Tasks.V3.V3Client(_client);
    }

    public global::Candid.Net.Tasks.V3.V3Client V3 { get; }
}
