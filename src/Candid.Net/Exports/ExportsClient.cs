using Candid.Net.Core;

namespace Candid.Net.Exports;

public partial class ExportsClient
{
    private RawClient _client;

    internal ExportsClient(RawClient client)
    {
        _client = client;
        V3 = new Candid.Net.Exports.V3.V3Client(_client);
    }

    public Candid.Net.Exports.V3.V3Client V3 { get; }
}
