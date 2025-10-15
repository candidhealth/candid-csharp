using Candid.Net.Core;

namespace Candid.Net.InsuranceRefunds;

public partial class InsuranceRefundsClient
{
    private RawClient _client;

    internal InsuranceRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.InsuranceRefunds.V1.V1Client(_client);
    }

    public Candid.Net.InsuranceRefunds.V1.V1Client V1 { get; }
}
