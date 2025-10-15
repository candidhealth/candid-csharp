using Candid.Net.Core;

namespace Candid.Net.InsurancePayments;

public partial class InsurancePaymentsClient
{
    private RawClient _client;

    internal InsurancePaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.InsurancePayments.V1.V1Client(_client);
    }

    public Candid.Net.InsurancePayments.V1.V1Client V1 { get; }
}
