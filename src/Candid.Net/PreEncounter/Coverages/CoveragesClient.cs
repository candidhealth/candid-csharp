using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages;

public partial class CoveragesClient
{
    private RawClient _client;

    internal CoveragesClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Coverages.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Coverages.V1.V1Client V1 { get; }
}
