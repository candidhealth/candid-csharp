using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus;

public partial class ExpectedNetworkStatusClient
{
    private RawClient _client;

    internal ExpectedNetworkStatusClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.ExpectedNetworkStatus.V1.V1Client(_client);
        V2 = new Candid.Net.ExpectedNetworkStatus.V2.V2Client(_client);
    }

    public Candid.Net.ExpectedNetworkStatus.V1.V1Client V1 { get; }

    public Candid.Net.ExpectedNetworkStatus.V2.V2Client V2 { get; }
}
