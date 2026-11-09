using global::Candid.Net.Core;

namespace Candid.Net.PayerGroups;

public partial class PayerGroupsClient : IPayerGroupsClient
{
    private readonly RawClient _client;

    internal PayerGroupsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PayerGroups.V1.V1Client(_client);
    }

    public global::Candid.Net.PayerGroups.V1.IV1Client V1 { get; }
}
