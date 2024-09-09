using Candid.Net.Core;
using Candid.Net.NonInsurancePayerRefunds.V1;

#nullable enable

namespace Candid.Net.NonInsurancePayerRefunds;

public partial class NonInsurancePayerRefundsClient
{
    private RawClient _client;

    internal NonInsurancePayerRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
