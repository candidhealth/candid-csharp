using Candid.Net.Core;
using Candid.Net.PreEncounter.EligibilityChecks.V1;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks;

public partial class EligibilityChecksClient
{
    private RawClient _client;

    internal EligibilityChecksClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
