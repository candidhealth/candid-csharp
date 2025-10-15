using Candid.Net.Core;

namespace Candid.Net.Guarantor;

public partial class GuarantorClient
{
    private RawClient _client;

    internal GuarantorClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.Guarantor.V1.V1Client(_client);
    }

    public Candid.Net.Guarantor.V1.V1Client V1 { get; }
}
