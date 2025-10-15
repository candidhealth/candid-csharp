using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerRefunds;

public partial class NonInsurancePayerRefundsClient
{
    private RawClient _client;

    internal NonInsurancePayerRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.NonInsurancePayerRefunds.V1.V1Client(_client);
    }

    public Candid.Net.NonInsurancePayerRefunds.V1.V1Client V1 { get; }
}
