using Candid.Net.Core;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.ServiceLines;

public partial class ServiceLinesClient
{
    private RawClient _client;

    internal ServiceLinesClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
    }

    public V2Client V2 { get; }
}
