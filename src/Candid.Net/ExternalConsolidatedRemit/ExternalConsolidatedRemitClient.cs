using global::Candid.Net.Core;

namespace Candid.Net.ExternalConsolidatedRemit;

public partial class ExternalConsolidatedRemitClient : IExternalConsolidatedRemitClient
{
    private readonly RawClient _client;

    internal ExternalConsolidatedRemitClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.ExternalConsolidatedRemit.V1.V1Client(_client);
    }

    public global::Candid.Net.ExternalConsolidatedRemit.V1.IV1Client V1 { get; }
}
