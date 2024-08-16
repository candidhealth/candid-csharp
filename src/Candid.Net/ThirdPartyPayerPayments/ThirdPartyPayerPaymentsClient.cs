using Candid.Net.Core;
using Candid.Net.ThirdPartyPayerPayments.V1;

#nullable enable

namespace Candid.Net.ThirdPartyPayerPayments;

public partial class ThirdPartyPayerPaymentsClient
{
    private RawClient _client;

    internal ThirdPartyPayerPaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
