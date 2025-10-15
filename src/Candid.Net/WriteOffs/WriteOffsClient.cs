using Candid.Net.Core;

namespace Candid.Net.WriteOffs;

public partial class WriteOffsClient
{
    private RawClient _client;

    internal WriteOffsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.WriteOffs.V1.V1Client(_client);
    }

    public Candid.Net.WriteOffs.V1.V1Client V1 { get; }
}
