using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerPayments;

public partial class NonInsurancePayerPaymentsClient
{
    private RawClient _client;

    internal NonInsurancePayerPaymentsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.NonInsurancePayerPayments.V1.V1Client(_client);
    }

    public global::Candid.Net.NonInsurancePayerPayments.V1.V1Client V1 { get; }
}
