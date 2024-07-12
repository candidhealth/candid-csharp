using Candid.Net.Core;
using Candid.Net.Eligibility.V2;

#nullable enable

namespace Candid.Net.Eligibility;

public class EligibilityClient
{
    private RawClient _client;

    public EligibilityClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
