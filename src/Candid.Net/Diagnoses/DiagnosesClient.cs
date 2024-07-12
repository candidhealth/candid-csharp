using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class DiagnosesClient
{
    private RawClient _client;

    public DiagnosesClient(RawClient client)
    {
        _client = client;
    }
}
