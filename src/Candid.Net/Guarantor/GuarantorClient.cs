using global::Candid.Net.Core;

namespace Candid.Net.Guarantor;

public partial class GuarantorClient : IGuarantorClient
{
    private readonly RawClient _client;

    internal GuarantorClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Guarantor.V1.V1Client(_client);
    }

    public global::Candid.Net.Guarantor.V1.IV1Client V1 { get; }
}
