using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles;

public partial class ChargeCaptureBundlesClient
{
    private RawClient _client;

    internal ChargeCaptureBundlesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.ChargeCaptureBundles.V1.V1Client(_client);
    }

    public global::Candid.Net.ChargeCaptureBundles.V1.V1Client V1 { get; }
}
