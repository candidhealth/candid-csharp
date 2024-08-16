using Candid.Net.Core;
using Candid.Net.Guarantor.V1;

#nullable enable

namespace Candid.Net.Guarantor;

public partial class GuarantorClient
{
    private RawClient _client;

    internal GuarantorClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
