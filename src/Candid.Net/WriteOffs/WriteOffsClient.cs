using Candid.Net.Core;
using Candid.Net.WriteOffs.V1;

#nullable enable

namespace Candid.Net.WriteOffs;

public class WriteOffsClient
{
    private RawClient _client;

    public WriteOffsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
