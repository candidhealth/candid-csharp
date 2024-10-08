using Candid.Net.Core;
using Candid.Net.InsuranceRefunds.V1;

#nullable enable

namespace Candid.Net.InsuranceRefunds;

public partial class InsuranceRefundsClient
{
    private RawClient _client;

    internal InsuranceRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
