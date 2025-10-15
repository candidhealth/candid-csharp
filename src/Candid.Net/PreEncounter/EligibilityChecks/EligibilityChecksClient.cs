using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks;

public partial class EligibilityChecksClient
{
    private RawClient _client;

    internal EligibilityChecksClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.EligibilityChecks.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.EligibilityChecks.V1.V1Client V1 { get; }
}
