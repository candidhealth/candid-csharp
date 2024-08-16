using Candid.Net.Contracts.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts;

public partial class ContractsClient
{
    private RawClient _client;

    internal ContractsClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
