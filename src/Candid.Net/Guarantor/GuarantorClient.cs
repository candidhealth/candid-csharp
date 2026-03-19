using Candid.Net.Core;

namespace Candid.Net.Guarantor;

public partial class GuarantorClient
{
    private RawClient _client;

    internal GuarantorClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Guarantor.V1.V1Client(_client);
    }

    public global::Candid.Net.Guarantor.V1.V1Client V1 { get; }
}
