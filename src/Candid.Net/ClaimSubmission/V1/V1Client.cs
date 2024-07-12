using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClaimSubmission.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }
}
