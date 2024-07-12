using Candid.Net.ClaimSubmission.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClaimSubmission;

public class ClaimSubmissionClient
{
    private RawClient _client;

    public ClaimSubmissionClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
