using Candid.Net.ChargeCaptureBundles.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles;

public partial class ChargeCaptureBundlesClient
{
    private RawClient _client;

    internal ChargeCaptureBundlesClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
