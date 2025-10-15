using Candid.Net.Core;

namespace Candid.Net.Superbills;

public partial class SuperbillsClient
{
    private RawClient _client;

    internal SuperbillsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.Superbills.V1.V1Client(_client);
    }

    public Candid.Net.Superbills.V1.V1Client V1 { get; }
}
