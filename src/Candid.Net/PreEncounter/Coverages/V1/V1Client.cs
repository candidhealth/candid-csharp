using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
        Coverages = new CoveragesClient(_client);
    }

    public CoveragesClient Coverages { get; }
}
