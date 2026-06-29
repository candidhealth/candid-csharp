using global::Candid.Net.Core;

namespace Candid.Net.FeeSchedules;

public partial class FeeSchedulesClient : IFeeSchedulesClient
{
    private readonly RawClient _client;

    internal FeeSchedulesClient(RawClient client)
    {
        _client = client;
        V3 = new global::Candid.Net.FeeSchedules.V3.V3Client(_client);
    }

    public global::Candid.Net.FeeSchedules.V3.IV3Client V3 { get; }
}
