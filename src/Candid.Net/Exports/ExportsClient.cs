using Candid.Net.Core;
using Candid.Net.Exports.V3;

#nullable enable

namespace Candid.Net.Exports;

public partial class ExportsClient
{
    private RawClient _client;

    internal ExportsClient(RawClient client)
    {
        _client = client;
        V3 = new V3Client(_client);
    }

    public V3Client V3 { get; }
}
