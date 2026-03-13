using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks;

public partial class EligibilityChecksClient : IEligibilityChecksClient
{
    private readonly RawClient _client;

    internal EligibilityChecksClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.EligibilityChecks.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.IV1Client V1 { get; }
}
