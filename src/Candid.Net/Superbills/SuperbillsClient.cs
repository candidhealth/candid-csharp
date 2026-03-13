using Candid.Net.Core;

namespace Candid.Net.Superbills;

public partial class SuperbillsClient : ISuperbillsClient
{
    private readonly RawClient _client;

    internal SuperbillsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Superbills.V1.V1Client(_client);
    }

    public global::Candid.Net.Superbills.V1.IV1Client V1 { get; }
}
