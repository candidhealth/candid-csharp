using Candid.Net.Core;

namespace Candid.Net.ServiceLines;

public partial class ServiceLinesClient
{
    private RawClient _client;

    internal ServiceLinesClient(RawClient client)
    {
        _client = client;
        V2 = new Candid.Net.ServiceLines.V2.V2Client(_client);
    }

    public Candid.Net.ServiceLines.V2.V2Client V2 { get; }
}
