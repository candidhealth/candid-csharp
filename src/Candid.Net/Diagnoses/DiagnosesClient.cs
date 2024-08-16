using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public partial class DiagnosesClient
{
    private RawClient _client;

    internal DiagnosesClient(RawClient client)
    {
        _client = client;
    }
}
