using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages;

public partial class CoveragesClient : ICoveragesClient
{
    private readonly RawClient _client;

    internal CoveragesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Coverages.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Coverages.V1.IV1Client V1 { get; }
}
