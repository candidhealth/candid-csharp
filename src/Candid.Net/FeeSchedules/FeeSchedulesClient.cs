using Candid.Net.Core;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules;

public class FeeSchedulesClient
{
    private RawClient _client;

    public FeeSchedulesClient(RawClient client)
    {
        _client = client;
        V3 = new V3Client(_client);
    }

    public V3Client V3 { get; }
}
