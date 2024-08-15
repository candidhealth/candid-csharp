using Candid.Net.Core;
using Candid.Net.ThirdPartyPayerPayments.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments;

public class ThirdPartyPayerPaymentsClient
{
    private RawClient _client;

    public ThirdPartyPayerPaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
