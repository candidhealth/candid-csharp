using Candid.Net.Core;

namespace Candid.Net.WriteOffs;

public partial class WriteOffsClient
{
    private RawClient _client;

    internal WriteOffsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.WriteOffs.V1.V1Client(_client);
    }

    public global::Candid.Net.WriteOffs.V1.V1Client V1 { get; }
}
