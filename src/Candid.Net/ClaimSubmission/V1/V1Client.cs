using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClaimSubmission.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }
}
