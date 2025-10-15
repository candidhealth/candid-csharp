using Candid.Net.Core;

namespace Candid.Net.ChargeCapture;

public partial class ChargeCaptureClient
{
    private RawClient _client;

    internal ChargeCaptureClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.ChargeCapture.V1.V1Client(_client);
    }

    public Candid.Net.ChargeCapture.V1.V1Client V1 { get; }
}
