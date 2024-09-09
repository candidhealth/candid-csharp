using Candid.Net.Core;
using Candid.Net.NonInsurancePayers.V1;

#nullable enable

namespace Candid.Net.NonInsurancePayers;

public partial class NonInsurancePayersClient
{
    private RawClient _client;

    internal NonInsurancePayersClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
