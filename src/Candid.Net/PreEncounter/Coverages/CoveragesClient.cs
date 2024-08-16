using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages;

public partial class CoveragesClient
{
    private RawClient _client;

    internal CoveragesClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
