using Candid.Net.Core;
using Candid.Net.ExternalPaymentAccountConfig.V1;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig;

public partial class ExternalPaymentAccountConfigClient
{
    private RawClient _client;

    internal ExternalPaymentAccountConfigClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
