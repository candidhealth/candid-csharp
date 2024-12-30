using Candid.Net.ChargeCapture.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture;

public partial class ChargeCaptureClient
{
    private RawClient _client;

    internal ChargeCaptureClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
