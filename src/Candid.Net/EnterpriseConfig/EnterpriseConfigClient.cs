using global::Candid.Net.Core;

namespace Candid.Net.EnterpriseConfig;

public partial class EnterpriseConfigClient : IEnterpriseConfigClient
{
    private readonly RawClient _client;

    internal EnterpriseConfigClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.EnterpriseConfig.V1.V1Client(_client);
    }

    public global::Candid.Net.EnterpriseConfig.V1.IV1Client V1 { get; }
}
