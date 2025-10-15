using Candid.Net.Core;

namespace Candid.Net.Contracts;

public partial class ContractsClient
{
    private RawClient _client;

    internal ContractsClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Contracts.V2.V2Client(_client);
    }

    public global::Candid.Net.Contracts.V2.V2Client V2 { get; }
}
