using Candid.Net.Core;

namespace Candid.Net.Eligibility;

public partial class EligibilityClient
{
    private RawClient _client;

    internal EligibilityClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.Eligibility.V2.V2Client(_client);
    }

    public global::Candid.Net.Eligibility.V2.V2Client V2 { get; }
}
