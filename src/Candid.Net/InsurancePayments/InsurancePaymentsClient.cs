using Candid.Net.Core;
using Candid.Net.InsurancePayments.V1;

#nullable enable

namespace Candid.Net.InsurancePayments;

public class InsurancePaymentsClient
{
    private RawClient _client;

    public InsurancePaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
