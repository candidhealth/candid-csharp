using Candid.Net.Core;

namespace Candid.Net.ExternalPaymentAccountConfig;

public partial class ExternalPaymentAccountConfigClient
{
    private RawClient _client;

    internal ExternalPaymentAccountConfigClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.ExternalPaymentAccountConfig.V1.V1Client(_client);
    }

    public Candid.Net.ExternalPaymentAccountConfig.V1.V1Client V1 { get; }
}
