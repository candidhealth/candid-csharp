using Candid.Net.Core;

namespace Candid.Net.Contracts;

public partial class ContractsClient
{
    private RawClient _client;

    internal ContractsClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Contracts.V2.V2Client(_client);
        V3 = new global::Candid.Net.Contracts.V3.V3Client(_client);
    }

    public global::Candid.Net.Contracts.V2.V2Client V2 { get; }

    public global::Candid.Net.Contracts.V3.V3Client V3 { get; }
}
