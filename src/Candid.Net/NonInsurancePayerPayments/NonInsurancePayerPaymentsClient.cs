using Candid.Net.Core;
using Candid.Net.NonInsurancePayerPayments.V1;

#nullable enable

namespace Candid.Net.NonInsurancePayerPayments;

public partial class NonInsurancePayerPaymentsClient
{
    private RawClient _client;

    internal NonInsurancePayerPaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
