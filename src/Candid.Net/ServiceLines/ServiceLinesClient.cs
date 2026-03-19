using global::Candid.Net.Core;

namespace Candid.Net.ServiceLines;

public partial class ServiceLinesClient : IServiceLinesClient
{
    private readonly RawClient _client;

    internal ServiceLinesClient(RawClient client)
    {
        _client = client;
        V2 = new global::Candid.Net.ServiceLines.V2.V2Client(_client);
    }

    public global::Candid.Net.ServiceLines.V2.IV2Client V2 { get; }
}
