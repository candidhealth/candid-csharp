using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers;

public partial class NonInsurancePayersClient
{
    private RawClient _client;

    internal NonInsurancePayersClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.NonInsurancePayers.V1.V1Client(_client);
    }

    public global::Candid.Net.NonInsurancePayers.V1.V1Client V1 { get; }
}
