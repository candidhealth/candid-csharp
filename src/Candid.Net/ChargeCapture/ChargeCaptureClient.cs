using global::Candid.Net.Core;

namespace Candid.Net.ChargeCapture;

public partial class ChargeCaptureClient : IChargeCaptureClient
{
    private readonly RawClient _client;

    internal ChargeCaptureClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.ChargeCapture.V1.V1Client(_client);
    }

    public global::Candid.Net.ChargeCapture.V1.IV1Client V1 { get; }
}
